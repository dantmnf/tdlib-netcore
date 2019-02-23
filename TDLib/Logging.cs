using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using static TDLib.Native;

namespace TDLib
{
    public unsafe class Logging
    {
        private static int loglevelvalue = 5;
        private static FatalErrorCallback savedcallback;
        public static int LogLevel
        {
            get => loglevelvalue;
            set
            {
                loglevelvalue = value;
                td_bridge_log_set_verbosity_level(value);
            }
        }

        public static unsafe bool SetLogFilePath(string path)
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

        public static void SetLogMaxFileSize(long maxsize)
        {
            td_bridge_log_set_max_file_size(maxsize);
        }

        public static void SetLogFatalErrorCallback(FatalErrorCallback callback)
        {
            savedcallback = callback;
            td_bridge_log_set_fatal_error_callback(savedcallback);
        }
    }
}
