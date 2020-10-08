using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using TDLib.Api;

namespace TDLib
{

    public abstract class Client : IDisposable
    {
        enum DirtyFlag { Clean, ManualSend, EventLoop }
        private class InvokeRecord
        {
            public TaskCompletionSource<TLObject> tsc;
        }

        private CancellationTokenSource loopcts;
        private ConcurrentDictionary<long, int> invokes;
        private Task loopTask;
        private DirtyFlag dirty = DirtyFlag.Clean;

        public event EventHandler<Update> Update;
        private int loopRunning;
        public bool EventLoopRunning => loopRunning != 0;



        /// <summary>
        /// Sends request to TDLib. May be called from any thread.
        /// </summary>
        /// <remarks>
        /// DO NOT use <see cref="Send(Function, long)"/> if event loop is being used.
        /// </remarks>
        /// <param name="func">TDLib API function representing a request to TDLib.</param>
        /// <param name="id">
        /// Request identifier.
        /// Responses to TDLib requests will have the same id as the corresponding request.
        /// Updates from TDLib will have id == 0, incoming requests are thus disallowed to have id == 0.
        /// </param>
        public void Send(Function func, long id = 0)
        {
            if (dirty == DirtyFlag.EventLoop)
            {
                throw new InvalidOperationException("Cannot use Client.Send if using event loop.");
            }
            dirty = DirtyFlag.ManualSend;
            DoSend(func, id);
        }
        internal protected abstract void DoSend(Function func, long id);

        /// <summary>
        /// Synchronously executes TDLib requests. Only a few requests can be executed synchronously.
        /// May be called from any thread.
        /// </summary>
        /// <param name="func">Request to the TDLib.</param>
        /// <returns>The request response.</returns>
        public abstract TLObject Execute(Function func);

        /// <summary>
        /// Receives incoming updates and request responses from TDLib.
        /// May be called from any thread, but shouldn't be called simultaneously from two different threads.
        /// </summary>
        /// <remarks>
        /// DO NOT use <see cref="Receive(double)"/> if event loop is being used.
        /// </remarks>
        /// <param name="timeout">Maximum number of seconds allowed for this function to wait for new data.</param>
        /// <returns>An incoming update or request response. The object returned in the response may be null if the timeout expires.</returns>
        public (long id, TLObject obj) Receive(double timeout)
        {
            if (dirty == DirtyFlag.EventLoop)
            {
                throw new InvalidOperationException("Cannot use Client.Receive if using event loop.");
            }
            return DoReceive(timeout);
        }
        internal protected abstract (long id, TLObject obj) DoReceive(double timeout);


        /// <summary>
        /// Execute function <paramref name="func"/> synchronously.
        /// See also <seealso cref="Execute(Function)"/>
        /// </summary>
        /// <typeparam name="T">The return type of <paramref name="func"/>.</typeparam>
        /// <param name="func">The function and parameters.</param>
        /// <returns>The return value of <paramref name="func"/>.</returns>
        /// <exception cref="TDLibError">Thrown if the function returns an <see cref="Error"/></exception>
        public T Execute<T>(Function<T> func) where T : TLObject
        {
            var obj = Execute((Function)func);
            if (obj is Error e)
            {
                throw new TDLibError(e);
            }
            return obj as T;
        }

        /// <summary>
        /// Starts the tdlib event loop. Required for <see cref="Update"/>, <see cref="InvokeAsync(Function)"/>, <see cref="InvokeAsync{T}(Function{T})"/>.
        /// </summary>
        public void RunEventLoop()
        {
            if (dirty == DirtyFlag.ManualSend)
            {
                throw new InvalidOperationException("Cannot run event loop after Client.Send.");
            }
            dirty = DirtyFlag.EventLoop;
            if (Interlocked.CompareExchange(ref loopRunning, 1, 0) == 0)
            {
                invokes = new ConcurrentDictionary<long, int>();
                loopcts = new CancellationTokenSource();
                loopTask = Run(loopcts.Token);
            }
        }

        /// <summary>
        /// Asks the tdlib event loop to stop.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/> that can be used to wait for stop.
        /// </returns>
        public Task StopEventLoop()
        {
            if (loopRunning != 0)
            {
                loopcts.Cancel();
                return loopTask;
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Invokes function <paramref name="func"/> asynchronously.
        /// </summary>
        /// <param name="func">The function and parameters to be invoked.</param>
        /// <returns>A Task that will resolve to the return value of <paramref name="func"/>.</returns>
        public Task<TLObject> InvokeAsync(Function func)
        {
            if (!EventLoopRunning) throw new InvalidOperationException("loop not running");
            var record = new InvokeRecord { tsc = new TaskCompletionSource<TLObject>(TaskCreationOptions.RunContinuationsAsynchronously) };
            var gch = GCHandle.Alloc(record, GCHandleType.Normal);
            var gchi = (long)GCHandle.ToIntPtr(gch);
            if (!invokes.TryAdd(gchi, default))
            {
                throw new IndexOutOfRangeException("duplicate GCHandle value");
            }
            DoSend(func, gchi);

            return record.tsc.Task;
        }

        /// <summary>
        /// See <seealso cref="InvokeAsync(Function)"/>.
        /// This overload returns the type defined by <paramref name="func"/>,
        /// or throws if the invocation returns an <see cref="Error"/>.
        /// </summary>
        /// <typeparam name="T">The return type of <paramref name="func"/></typeparam>
        /// <param name="func">The function and parameters to be invoked.</param>
        /// <returns>A Task that will resolve to the return value of <paramref name="func"/>.</returns>
        /// <exception cref="TDLibError">Thrown if the function returns an <see cref="Error"/></exception>
        public async Task<T> InvokeAsync<T>(Function<T> func) where T : TLObject
        {
            var result = await InvokeAsync((Function)func);
            if (result is Error e)
            {
                throw new TDLibError(e);
            }
            return result as T;
        }


        private void HandleReceivedObject(TLObject obj, long extra)
        {
            if (obj is Update u)
            {
                var snapshot = Update;
                snapshot?.Invoke(this, u);
            }
            if (extra != 0)
            {
                if (!invokes.TryRemove(extra, out _))
                {
                    throw new IndexOutOfRangeException("unregistered GCHandle value");
                }
                var gch = GCHandle.FromIntPtr((IntPtr)extra);
                var record = (InvokeRecord)gch.Target;
                gch.Free();
                record.tsc.TrySetResult(obj);
            }
        }

        private void CancelPendingInvocations(CancellationToken ct)
        {
            var handles = invokes.Keys.ToArray();
            invokes.Clear();
            foreach (var gchi in handles)
            {
                var gch = GCHandle.FromIntPtr((IntPtr)gchi);
                var record = (InvokeRecord)gch.Target;
                gch.Free();
                record.tsc.TrySetCanceled(ct);
            }
        }

        private Task Run(CancellationToken ct)
        {
            var task = Task.Run(() =>
            {
                ct.Register(() =>
                {
                    _ = InvokeAsync(new TestCallEmpty());  // to make Receive return;
                });
                while (!ct.IsCancellationRequested)
                {
                    var (seq, obj) = DoReceive(10.0);
                    if (obj == null) continue;
                    HandleReceivedObject(obj, seq);
                }
                CancelPendingInvocations(ct);
                Interlocked.CompareExchange(ref loopRunning, 0, 1);
            });
            return task;
        }

        protected abstract void DisposeNativeClient();

        ~Client()
        {
            Dispose();
        }

        public void Dispose()
        {
            StopEventLoop().Wait();
            DisposeNativeClient();
            GC.SuppressFinalize(this);
        }
    }
}
