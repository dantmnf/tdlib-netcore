using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using TDLibCore.Api;

namespace TDLibCore
{
    /// <summary>
    /// Generic wrapper for clients with blocking receive call.
    /// </summary>
    /// <remarks>
    /// Each <see cref="ExclusiveWorkerClient"/> instance uses its own worker thread to receive updates and responses.
    /// You may encounter problems when using a large number of <see cref="ExclusiveWorkerClient"/> instances.
    /// </remarks>
    public sealed class ExclusiveWorkerClient : Client
    {
        private class InvokeRecord
        {
            public TaskCompletionSource<TLObject> tsc;
        }

        private IExclusiveWorkerClientImpl binding;
        private CancellationTokenSource loopcts;
        private ConcurrentDictionary<long, int> invokes;
        private Task loopTask;

        private int loopRunning;
        public bool EventLoopRunning => loopRunning != 0;
        private int disposing = 0;
        private int disposed = 0;


        public ExclusiveWorkerClient(Func<IExclusiveWorkerClientImpl> factory, EventHandler<Update> updateHandler) : base(updateHandler)
        {
            binding = factory();
            RunEventLoop();
        }

        private void CheckDisposed()
        {
            if (disposed != 0) throw new ObjectDisposedException(nameof(ExclusiveWorkerClient));
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
        private void Send(Function func, long id = 0)
        {
            CheckDisposed();
            binding.Send(func, id);
        }


        public override TLObject Execute(Function func) {
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
        private (long id, TLObject obj) Receive(double timeout)
        {
            CheckDisposed();
            return binding.Receive(timeout);
        }

        /// <summary>
        /// Starts the tdlib event loop. Required for <see cref="Update"/>, <see cref="InvokeAsync(Function)"/>, <see cref="InvokeAsync{T}(Function{T})"/>.
        /// </summary>
        private void RunEventLoop()
        {
            CheckDisposed();
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
        private Task StopEventLoop()
        {
            CheckDisposed();
            if (loopRunning != 0)
            {
                loopcts.Cancel();
                return loopTask;
            }
            return Task.CompletedTask;
        }


        public override Task<TLObject> InvokeAsync(Function func)
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


        private void HandleReceivedObject(TLObject obj, long extra)
        {
            if (obj is Update u)
            {
                HandleUpdate(u);
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
                while (clientClosed && !ct.IsCancellationRequested)
                {
                    var (seq, obj) = binding.Receive(10.0);
                    if (obj == null) continue;
                    HandleReceivedObject(obj, seq);
                }
                CancelPendingInvocations(ct);
                Interlocked.Exchange(ref loopRunning, 0);
            });
            return task;
        }

        ~ExclusiveWorkerClient()
        {
            Dispose();
        }

        public override void Dispose()
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

        public override async ValueTask DisposeAsync()
        {
            if (Interlocked.Exchange(ref disposing, 1) != 0) return;
            await Close();
            binding.Dispose();
            GC.SuppressFinalize(this);
            Interlocked.Exchange(ref disposed, 1);
        }
    }
}
