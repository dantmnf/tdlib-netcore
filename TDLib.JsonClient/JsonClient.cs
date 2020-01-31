using System;
using System.IO;
using TDLib;
using TDLib.Api;
using static TDLib.JsonClient.Native;

namespace TDLib.JsonClient
{
    public unsafe sealed class JsonClient : Client, IDisposable
    {
        public static ITdClientLogging Logging { get; private set; } = new JsonClientLogging();
        private IntPtr unmanaged_client;
        public JsonClient()
        {
            unmanaged_client = td_json_client_create();
        }

        private static TLObjectWithExtra CStringToTLObject(ReadOnlySpan<byte> cstr)
        {
            if (cstr.IsEmpty || cstr.Length == 0) return new TLObjectWithExtra();

            TdJsonReader parser = new TdJsonReader(cstr);
            var obj = parser.ReadTLObject();
            return obj;
        }

        private static ArraySegment<byte> TLObjectToBytes(TLObjectWithExtra obj)
        {
            var s = new MemoryStream(128);
            var writer = new TdJsonWriter(s);
            writer.WriteValue(obj);
            s.WriteByte(0);
            if (s.TryGetBuffer(out var buf))
            {
                return buf;
            }
            else
            {
                return s.ToArray();
            }
        }

        public override TLObject Execute(Function func)
        {
            var requestbytes = TLObjectToBytes(new TLObjectWithExtra { TLObject = func });
            byte* result;
            fixed (byte* str = requestbytes.Array)
                result = td_json_client_execute(unmanaged_client, str + requestbytes.Offset);
            if (result == null) return null;
            var obj = CStringToTLObject(new ReadOnlySpan<byte>(result, strlen(result)));
            return obj.TLObject;
        }

        public override (long id, TLObject obj) Receive(double timeout)
        {
            var result = (byte*)td_json_client_receive(unmanaged_client, timeout);
            if (result == null) return (0, null);
            var obj = CStringToTLObject(new ReadOnlySpan<byte>(result, strlen(result)));
            return (obj.Extra, obj.TLObject);
        }

        public override void Send(Function func, long id = 99)
        {
            var requestbytes = TLObjectToBytes(new TLObjectWithExtra { TLObject = func, HasExtra = true, Extra = id });
            fixed (byte* str = requestbytes.AsSpan())
                td_json_client_send(unmanaged_client, str);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        public void Dispose()
        {
            if (!disposedValue)
            {
                if (unmanaged_client != IntPtr.Zero)
                    td_json_client_destroy(unmanaged_client);

                disposedValue = true;
                GC.SuppressFinalize(this);

            }
        }

         ~JsonClient()
        {
            Dispose();
        }

        #endregion
    }
}
