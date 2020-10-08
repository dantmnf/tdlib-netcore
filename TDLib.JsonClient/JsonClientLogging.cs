using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TDLib.JsonClient
{
    internal class JsonClientLogging : ITdClientLogging
    {
        private static int loglevelvalue = 5;
        private static Native.td_log_fatal_error_callback_ptr mappedcallback;
        public int VerbosityLevel
        {
            get => loglevelvalue;
            set
            {
                loglevelvalue = value;
                Native.td_set_log_verbosity_level(value);
            }
        }

        public unsafe bool SetLogFilePath(string path)
        {
            if(path == null)
            {
                return Native.td_set_log_file_path(IntPtr.Zero) != 0;
            }
            else
            {
                var utf8bytes = new byte[Encoding.UTF8.GetByteCount(path) + 1];
                Encoding.UTF8.GetBytes(path, 0, path.Length, utf8bytes, 0);
                fixed (byte* cstr = utf8bytes)
                    return Native.td_set_log_file_path(new IntPtr(cstr)) != 0;
            }
        }

        public void SetLogMaxFileSize(long maxsize)
        {
            Native.td_set_log_max_file_size(maxsize);
        }

        public void SetLogFatalErrorCallback(Action<string> callback)
        {
            mappedcallback = cstrptr =>
            {
                unsafe
                {
                    var cstr = (byte*)cstrptr;
                    var netstr = Encoding.UTF8.GetString(cstr, (int)Native.strlen(cstr));
                    callback(netstr);
                }
            };
            // the delegate stub is not in GC heap
            Native.td_set_log_fatal_error_callback(mappedcallback);
        }
    }
}
