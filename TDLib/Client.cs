using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using TDLib.Api;
using System.Threading;
using System.Threading.Tasks;

namespace TDLib
{
    public class Client : IDisposable
    {
        private readonly ConcurrentDictionary<long, TaskCompletionSource<TLObject>> invokes;
        private readonly CancellationTokenSource cts;
        private readonly CancellationToken ct;
        private Task loopTask;
        private long invoke_sequence = 100;
        private readonly ITdClientImpl clientImpl;

        public event EventHandler<Update> Update;


        internal Client(ITdClientImpl impl)
        {
            clientImpl = impl;
            invokes = new ConcurrentDictionary<long, TaskCompletionSource<TLObject>>();
            cts = new CancellationTokenSource();
            ct = cts.Token;
        }

        public Client() : this(new ClientImplCxx())
        {
        }

        /// <summary>
        /// Execute function <paramref name="func"/> synchronously.
        /// <seealso cref="Execute(Function)"/>
        /// </summary>
        /// <typeparam name="T">The return type of <paramref name="func"/>.</typeparam>
        /// <param name="func">The function and parameters.</param>
        /// <returns>The return value of <paramref name="func"/>.</returns>
        /// <exception cref="TDLibError">Thrown if the function returns an <see cref="error"/></exception>
        public T Execute<T>(Function<T> func) where T : TLObject
        {
            var obj = clientImpl.Execute((Function)func);
            if (obj is Error e)
            {
                throw new TDLibError(e);
            }
            return obj as T;
        }

        private long AddInvoke(TaskCompletionSource<TLObject> tsc)
        {
            while (true)
            {
                Interlocked.Increment(ref invoke_sequence);
                var seq = invoke_sequence;
                if (seq != 0 && invokes.TryAdd(seq, tsc))
                    return seq;
            }
        }

        /// <summary>
        /// Invokes function <paramref name="func"/> asynchronously.
        /// </summary>
        /// <param name="func">The function and parameters to be invoked.</param>
        /// <returns>A Task that will resolve to the return value of <paramref name="func"/>.</returns>
        public Task<TLObject> InvokeAsync(Function func)
        {
            var tsc = new TaskCompletionSource<TLObject>();
            var seq = AddInvoke(tsc);
            clientImpl.Send(seq, func);

            return tsc.Task;
        }

        /// <summary>
        /// <seealso cref="InvokeAsync(Function)"/>.
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


        public Task<Update> WaitForUpdate(Func<Update, bool> criterion, CancellationToken ct = default(CancellationToken))
        {
            var tsc = new TaskCompletionSource<Update>();
            void handler(object sender, Update u)
            {
                if (criterion(u))
                {
                    Update -= handler;
                    tsc.TrySetResult(u);
                }
            }

            Update += handler;
            ct.Register(() =>
            {
                Update -= handler;
                tsc.TrySetCanceled(ct);
            });
            return tsc.Task;
        }


        private void RunLoop()
        {
            while (!ct.IsCancellationRequested)
            {
                var (seq, obj) = clientImpl.Receive(1.0);
                if (obj == null) continue;
                if (obj is Update u)
                {
                    Update?.Invoke(this, u);
                    // TODO
                }
                if (seq != 0)
                {
                    if (invokes.TryRemove(seq, out var tsc))
                    {
                        tsc.SetResult(obj);
                    }
                }
            }
        }

        /// <summary>
        /// Starts the tdlib event loop. Required for <see cref="InvokeAsync(Function)"/>, <see cref="InvokeAsync{T}(Function{T})"/>.
        /// </summary>
        /// <returns>The event loop Task.</returns>
        public Task Run()
        {
            if (loopTask == null)
            {
                loopTask = Task.Run(() =>
                {
                    RunLoop();
                });
            }
            return loopTask;
        }

        /// <summary>
        /// Requests the event loop to stop.
        /// </summary>
        /// <returns>The event loop Task, which can be awaited for stop, or a canceled Task if the event loop is not started.</returns>
        public Task StopAsync()
        {
            cts.Cancel();
            if (loopTask != null)
            {
                return loopTask;
            }
            return Task.FromCanceled(default);
        }

        #region IDisposable
        public void Dispose()
        {
            (clientImpl as IDisposable)?.Dispose();
            GC.SuppressFinalize(this);
        }

        ~Client()
        {
            Dispose();
        }
        #endregion


    }
}
