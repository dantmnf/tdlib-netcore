using System;
using System.Threading;
using TDLibCore.Api;
using TDLibCore.NativeClient.CxxInterop;
using static TDLibCore.NativeClient.Native;


namespace TDLibCore.NativeClient
{
    public static class NativeClient
    {
        public static ITdClientLogging Logging { get; } = new CxxClientLogging();
        private static readonly Func<IExclusiveWorkerClientImpl> factory = static () => new Binding();
        public static ExclusiveWorkerClient Create(EventHandler<Update> updateHandler)
        {
            return new ExclusiveWorkerClient(factory, updateHandler);
        }

        public static TLObject Execute(Function func)
        {
            TLObject obj = null;
            var ptr = td_bridge_client_execute(TLObjectFactory.CreateCxxObject(func));
            if (ptr != IntPtr.Zero)
                obj = TLObjectFactory.FetchAndFreeCxxObject(ptr);
            return obj;
        }

        public class Binding : IExclusiveWorkerClientImpl
        {
            ITdClientLogging IExclusiveWorkerClientImpl.GlobalLogging => Logging;

            private IntPtr ptr;
            public IntPtr Handle => ptr;

            internal Binding()
            {
                ptr = td_bridge_client_create();
            }

            public TLObject Execute(Function func)
            {
                TLObject obj = null;
                var ptr = td_bridge_client_execute(TLObjectFactory.CreateCxxObject(func));
                if (ptr != IntPtr.Zero)
                    obj = TLObjectFactory.FetchAndFreeCxxObject(ptr);
                return obj;
            }

            public (long, TLObject) Receive(double timeout)
            {
                //var objptr = td_bridge_client_receive(ptr, timeout, out var id);
                //return (id, FetchAndFreeObject(objptr));
                if (ptr == IntPtr.Zero) throw new ObjectDisposedException(nameof(Binding));
                TLObject obj = null;
                long id = 0;
                td_bridge_client_receive(ptr, timeout, out id);
                if (ptr != IntPtr.Zero)
                    obj = TLObjectFactory.FetchAndFreeCxxObject(ptr);
                return (id, obj);
            }

            public void Send(Function func, long id)
            {
                if (ptr == IntPtr.Zero) throw new ObjectDisposedException(nameof(Binding));
                td_bridge_client_send(ptr, id, TLObjectFactory.CreateCxxObject(func));
            }

            private int disposed = 0;
            public void Dispose()
            {
                if (Interlocked.CompareExchange(ref disposed, 1, 0) == 0)
                {
                    td_bridge_client_destroy(ptr);
                }
            }
        }
    }
}
