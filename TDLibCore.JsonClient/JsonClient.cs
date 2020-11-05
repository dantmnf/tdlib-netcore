using System;
using System.Buffers;
using System.Text.Json;
using System.Threading;
using TDLibCore.Api;
using static TDLibCore.JsonClient.Native;

namespace TDLibCore.JsonClient
{
    public static unsafe class JsonClient
    {
        public static ITdClientLogging Logging { get; } = new JsonClientLogging();

        private class JsonClientBindingFactory : ITdClientBindingFactory
        {
            public ITdClientLogging GlobalLogging => Logging;
            public ITdClientBinding CreateInstance() => new Binding();
        }

        public static ITdClientBindingFactory BindingFactory { get; } = new JsonClientBindingFactory();

        public static Client Create()
        {
            return new Client(BindingFactory);
        }

        public class Binding : ITdClientBinding
        {
            ITdClientLogging ITdClientBinding.GlobalLogging => Logging;

            private readonly IntPtr client;
            public IntPtr Handle => client;
            internal Binding()
            {
                client = td_json_client_create();
            }

            private static unsafe TLObjectWithExtra FetchObject(byte* cstr)
            {
                if (cstr == null || *cstr == 0) return new TLObjectWithExtra();

                var span = new ReadOnlySpan<byte>(cstr, CString.strlen(cstr));
                var obj = TLObjectFactory.ReadRootObject(span);
                return obj;
            }

            TLObject ITdClientBinding.Execute(Function func)
            {
                using var buffer = new ArrayPoolBufferWriter<byte>(512);
                TLObjectFactory.DumpObject(buffer, func);
                var requestbytes = buffer.WrittenSpan;
                byte* result;
                fixed (byte* str = requestbytes)
                    result = td_json_client_execute(client, str);
                if (result == null) return null;
                var obj = FetchObject(result);
                return obj.TLObject;
            }

            (long id, TLObject obj) ITdClientBinding.Receive(double timeout)
            {
                var result = (byte*)td_json_client_receive(client, timeout);
                if (result == null) return (0, null);
                var obj = FetchObject(result);
                return (obj.Extra.GetValueOrDefault(), obj.TLObject);
            }

            void ITdClientBinding.Send(Function func, long id)
            {
                using var buffer = new ArrayPoolBufferWriter<byte>(512);
                TLObjectFactory.DumpObject(buffer, new TLObjectWithExtra(func, id));
                var requestbytes = buffer.WrittenSpan;
                fixed (byte* str = requestbytes)
                    td_json_client_send(client, str);
            }

            private int disposed = 0;
            void IDisposable.Dispose()
            {
                if (Interlocked.Exchange(ref disposed, 1) == 0)
                {
                    td_json_client_destroy(client);
                }
            }
        }

    }
}
