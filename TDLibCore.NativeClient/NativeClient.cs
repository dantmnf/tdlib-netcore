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
        public static ITdClientBindingFactory BindingFactory { get; } = new NativeClientBindingFactory();
        public static Client Create()
        {
            return new Client(BindingFactory);
        }

        private class NativeClientBindingFactory : ITdClientBindingFactory
        {
            public ITdClientLogging GlobalLogging => Logging;
            public ITdClientBinding CreateInstance() => new Binding();
        }


        public class Binding : ITdClientBinding
        {
            ITdClientLogging ITdClientBinding.GlobalLogging => Logging;

            private IntPtr ptr;
            public IntPtr Handle => ptr;

            internal Binding()
            {
                ptr = td_bridge_client_create();
            }

            TLObject ITdClientBinding.Execute(Function func)
            {
                //var objptr = td_bridge_client_execute(ptr, 114514, TLObjectFactory.CreateCxxObject(func), out var id);
                //return FetchAndFreeObject(ptr);

                TLObject obj = null;
                td_bridge_client_execute(ptr, 114514, TLObjectFactory.CreateCxxObject(func), (ptr, id) =>
                {
                    if (ptr != IntPtr.Zero)
                        obj = TLObjectFactory.FetchCxxObject(ptr);
                });
                return obj;
            }

            (long, TLObject) ITdClientBinding.Receive(double timeout)
            {
                //var objptr = td_bridge_client_receive(ptr, timeout, out var id);
                //return (id, FetchAndFreeObject(objptr));
                if (ptr == IntPtr.Zero) throw new ObjectDisposedException(nameof(NativeClient));
                TLObject obj = null;
                long id = 0;
                td_bridge_client_receive(ptr, timeout, (ptr, id_) =>
                {
                    if (ptr != IntPtr.Zero)
                    {
                        obj = TLObjectFactory.FetchCxxObject(ptr);
                        id = id_;
                    }
                });
                return (id, obj);
            }

            void ITdClientBinding.Send(Function func, long id)
            {
                if (ptr == IntPtr.Zero) throw new ObjectDisposedException(nameof(NativeClient));
                td_bridge_client_send(ptr, id, TLObjectFactory.CreateCxxObject(func));
            }

            private int disposed = 0;
            void IDisposable.Dispose()
            {
                if (Interlocked.CompareExchange(ref disposed, 1, 0) == 0)
                {
                    td_bridge_client_destroy(ptr);
                }
            }
        }
    }
}
