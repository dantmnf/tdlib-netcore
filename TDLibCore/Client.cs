using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using TDLibCore.Api;

namespace TDLibCore
{

    public sealed class Client : IDisposable, IAsyncDisposable
    {
        enum DirtyFlag { Clean, ManualSend, EventLoop }
        private class InvokeRecord
        {
            public TaskCompletionSource<TLObject> tsc;
        }

        private ITdClientBinding binding;
        private CancellationTokenSource loopcts;
        private ConcurrentDictionary<long, int> invokes;
        private Task loopTask;
        private volatile int dirty = (int)DirtyFlag.Clean;

        public event EventHandler<Update> Update;
        private int loopRunning;
        public bool EventLoopRunning => loopRunning != 0;
        private int disposing = 0;
        private int disposed = 0;

        public Client(ITdClientBindingFactory factory)
        {
            binding = factory.CreateInstance();
        }

        private void CheckDisposed()
        {
            if (disposed != 0) throw new ObjectDisposedException(nameof(Client));
        }

        private void MarkDirty(DirtyFlag flag)
        {
            var dirty_snapshot = (DirtyFlag)dirty;
            if (dirty_snapshot == DirtyFlag.Clean)
            {
                if (Interlocked.CompareExchange(ref dirty, (int)flag, (int)DirtyFlag.Clean) == (int)DirtyFlag.Clean)
                {
                    return;
                }
                throw new InvalidOperationException($"Object state changed in another thread while attempting to set flag {flag}.");
            }
            if (dirty_snapshot != flag)
            {
                throw new InvalidOperationException($"Cannot use {flag} alongside with {dirty_snapshot}.");
            }
        }

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
            CheckDisposed();
            MarkDirty(DirtyFlag.ManualSend);
            binding.Send(func, id);
        }

        /// <summary>
        /// Synchronously executes TDLib requests. Only a few requests can be executed synchronously.
        /// May be called from any thread.
        /// </summary>
        /// <param name="func">Request to the TDLib.</param>
        /// <returns>The request response.</returns>
        public TLObject Execute(Function func) {
            CheckDisposed();
            return binding.Execute(func);
        }

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
            CheckDisposed();
            MarkDirty(DirtyFlag.ManualSend);
            return binding.Receive(timeout);
        }

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
            CheckDisposed();
            MarkDirty(DirtyFlag.EventLoop);
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
            CheckDisposed();
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
            CheckDisposed();
            if (!EventLoopRunning) RunEventLoop();
            var record = new InvokeRecord { tsc = new TaskCompletionSource<TLObject>(TaskCreationOptions.RunContinuationsAsynchronously) };
            var gch = GCHandle.Alloc(record, GCHandleType.Normal);
            var gchi = (long)GCHandle.ToIntPtr(gch);
            if (!invokes.TryAdd(gchi, default))
            {
                throw new IndexOutOfRangeException("duplicate GCHandle value");
            }
            binding.Send(func, gchi);

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


        private void HandleReceivedObject(TLObject obj, long extra, ref bool closed)
        {
            if (obj is Update u)
            {
                var snapshot = Update;
                snapshot?.Invoke(this, u);
                if(u is UpdateAuthorizationState uas && uas.AuthorizationState is AuthorizationStateClosed)
                {
                    closed = true;
                }
            }
            else if (extra != 0)
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
                var closed = false;
                while (!closed && !ct.IsCancellationRequested)
                {
                    var (seq, obj) = binding.Receive(10.0);
                    if (obj == null) continue;
                    HandleReceivedObject(obj, seq, ref closed);
                }
                CancelPendingInvocations(ct);
                Interlocked.Exchange(ref loopRunning, 0);
            });
            return task;
        }

        ~Client()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (Interlocked.Exchange(ref disposing, 1) != 0) return;
            Close().Wait();
            binding.Dispose();
            GC.SuppressFinalize(this);
            Interlocked.Exchange(ref disposed, 1);
        }

        private int closeinvoked = 0;
        public async Task Close()
        {
            if (Interlocked.Exchange(ref closeinvoked, 1) == 1) return;
            await InvokeAsync((Function)new Close());
            await loopTask;
        }

        public async ValueTask DisposeAsync()
        {
            if (Interlocked.Exchange(ref disposing, 1) != 0) return;
            await Close();
            binding.Dispose();
            GC.SuppressFinalize(this);
            Interlocked.Exchange(ref disposed, 1);
        }
    }
}
