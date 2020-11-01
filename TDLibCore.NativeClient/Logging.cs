using System;
using System.Text;
using static TDLibCore.NativeClient.Native;

namespace TDLibCore.NativeClient
{
    internal class CxxClientLogging : ITdClientLogging
    {
        private int loglevelvalue = 5;
        private FatalErrorCallback savedcallback;
        public int VerbosityLevel
        {
            get => loglevelvalue;
            set
            {
                loglevelvalue = value;
                td_bridge_log_set_verbosity_level(value);
            }
        }

        public unsafe bool SetLogFilePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return td_bridge_log_set_file_path(null, 0);
            }
            else
            {
                var utf8bytes = Encoding.UTF8.GetBytes(path);
                fixed (byte* cstr = utf8bytes)
                    return td_bridge_log_set_file_path(cstr, utf8bytes.LongLength);
            }
        }

        public void SetLogMaxFileSize(long maxsize)
        {
            td_bridge_log_set_max_file_size(maxsize);
        }

        public unsafe void SetLogFatalErrorCallback(Action<string> callback)
        {
            savedcallback = (iptr) =>
            {
                var ptr = (byte*)iptr;
                var len = strlen(ptr);
                var str = Encoding.UTF8.GetString(ptr, len);
                callback.Invoke(str);
            };
            td_bridge_log_set_fatal_error_callback(savedcallback);
        }
    }
}
