using System;
using System.Buffers;
using System.Threading;
using TDLib.Api;
using static TDLib.JsonClient.Native;

namespace TDLib.JsonClient
{
    public unsafe sealed class JsonClient : Client
    {
        public static ITdClientLogging Logging { get; private set; } = new JsonClientLogging();
        private IntPtr unmanaged_client;
        public JsonClient()
        {
            unmanaged_client = td_json_client_create();
        }

        internal static TLObjectWithExtra CStringToTLObject(byte* cstr)
        {
            if (cstr == null || *cstr == 0) return new TLObjectWithExtra();

            TdJsonReader parser = new TdJsonReader(cstr);
            var obj = TLObjectFactory.ReadRootObject(ref parser);
            return obj;
        }

        internal static ReadOnlySpan<byte> TLObjectToBytes(TLObjectWithExtra obj)
        {
            var buffer = new ArrayPoolBufferWriter<byte>(512);
            var writer = new TdJsonBufferWriter(buffer);
            writer.WriteValue(obj);
            byte zero = 0;
            buffer.Write(new ReadOnlySpan<byte>(&zero, 1));
            return buffer.WrittenSpan;
        }

        public override TLObject Execute(Function func)
        {
            var requestbytes = TLObjectToBytes(new TLObjectWithExtra { TLObject = func });
            byte* result;
            fixed (byte* str = requestbytes)
                result = td_json_client_execute(unmanaged_client, str);
            if (result == null) return null;
            var obj = CStringToTLObject(result);
            return obj.TLObject;
        }

        protected override (long id, TLObject obj) DoReceive(double timeout)
        {
            var result = (byte*)td_json_client_receive(unmanaged_client, timeout);
            if (result == null) return (0, null);
            var obj = CStringToTLObject(result);
            return (obj.Extra.GetValueOrDefault(), obj.TLObject);
        }

        protected override void DoSend(Function func, long id = 99)
        {
            var buffer = stackalloc byte[512];
            var requestbytes = TLObjectToBytes(new TLObjectWithExtra { TLObject = func, Extra = id });
            fixed (byte* str = requestbytes)
                td_json_client_send(unmanaged_client, str);
        }

        private int disposed = 0;
        protected override void DisposeNativeClient()
        {
            if (Interlocked.CompareExchange(ref disposed, 1, 0) == 0)
            {
                td_json_client_destroy(unmanaged_client);
            }
        }

    }
}
