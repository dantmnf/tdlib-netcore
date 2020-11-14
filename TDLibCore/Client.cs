using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TDLibCore.Api;

namespace TDLibCore
{
    public abstract class Client : IDisposable, IAsyncDisposable
    {
        public abstract void Dispose();
        public abstract ValueTask DisposeAsync();

        public event EventHandler<Update> Update;

        protected Client(EventHandler<Update> updateHandler)
        {
            Update = updateHandler;
        }

        protected bool clientClosed = false;
        private TaskCompletionSource<bool> clientClosedSource = new(TaskCreationOptions.RunContinuationsAsynchronously);
        protected Task WaitClientClosed() => clientClosedSource.Task;

        protected void HandleUpdate(Update u)
        {
            var snapshot = Update;
            snapshot?.Invoke(this, u);
            if (u is UpdateAuthorizationState uas && uas.AuthorizationState is AuthorizationStateClosed)
            {
                clientClosed = true;
                clientClosedSource.SetResult(true);
            }
        }
        /// <summary>
        /// Synchronously executes TDLib requests. Only a few requests can be executed synchronously.
        /// May be called from any thread.
        /// </summary>
        /// <param name="func">Request to the TDLib.</param>
        /// <returns>The request response.</returns>
        public abstract TLObject Execute(Function func);

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
        /// Invokes function <paramref name="func"/> asynchronously.
        /// </summary>
        /// <param name="func">The function and parameters to be invoked.</param>
        /// <returns>A Task that will resolve to the return value of <paramref name="func"/>.</returns>
        public abstract Task<TLObject> InvokeAsync(Function func);

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
    }
}
