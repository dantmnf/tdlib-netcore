using System;
using System.Buffers;
using System.Text.Json;
using System.Threading;
using TDLib.Api;
using static TDLib.JsonClient.Native;

namespace TDLib.JsonClient
{
    public sealed unsafe class JsonClient : Client
    {
        public static ITdClientLogging Logging { get; } = new JsonClientLogging();
        private IntPtr unmanaged_client;
        public JsonClient()
        {
            unmanaged_client = td_json_client_create();
        }

        internal static TLObjectWithExtra FetchObject(byte* cstr)
        {
            if (cstr == null || *cstr == 0) return new TLObjectWithExtra();

            var span = new ReadOnlySpan<byte>(cstr, (int)strlen(cstr));
            var parser = new Utf8JsonReader(span);
            var obj = TLObjectFactory.ReadRootObject(ref parser);
            return obj;
        }

        internal static void DumpObject(TLObjectWithExtra obj, IBufferWriter<byte> buffer)
        {
            using var writer = new Utf8JsonWriter(buffer, new JsonWriterOptions { Indented = false });
            writer.WriteTLObjectValue(obj);
            writer.Flush();
            var span = buffer.GetSpan(1);
            span[0] = 0;
            buffer.Advance(1);
        }

        public override TLObject Execute(Function func)
        {
            using var buffer = new ArrayPoolBufferWriter<byte>(512);
            DumpObject(new TLObjectWithExtra { TLObject = func }, buffer);
            var requestbytes = buffer.WrittenSpan;
            byte * result;
            fixed (byte* str = requestbytes)
                result = td_json_client_execute(unmanaged_client, str);
            if (result == null) return null;
            var obj = FetchObject(result);
            return obj.TLObject;
        }

        protected override (long id, TLObject obj) DoReceive(double timeout)
        {
            var result = (byte*)td_json_client_receive(unmanaged_client, timeout);
            if (result == null) return (0, null);
            var obj = FetchObject(result);
            return (obj.Extra.GetValueOrDefault(), obj.TLObject);
        }

        protected override void DoSend(Function func, long id)
        {
            using var buffer = new ArrayPoolBufferWriter<byte>(512);
            DumpObject(new TLObjectWithExtra { TLObject = func }, buffer);
            var requestbytes = buffer.WrittenSpan;
            fixed (byte* str = requestbytes)
                td_json_client_send(unmanaged_client, str);
        }

        private int disposed = 0;
        protected override void DisposeNativeClient()
        {
            if (Interlocked.Exchange(ref disposed, 1) == 0)
            {
                td_json_client_destroy(unmanaged_client);
            }
        }

    }
}
