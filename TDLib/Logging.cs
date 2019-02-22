using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using static TDLib.Native;

namespace TDLib
{
    public unsafe class Logging
    {
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool td_bridge_log_set_file_path(byte* file_path, long len);

        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_log_set_max_file_size(long max_file_size);

        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_log_set_verbosity_level(int new_verbosity_level);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FatalErrorCallback([MarshalAs(UnmanagedType.LPUTF8Str)]string message);

        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_log_set_fatal_error_callback(FatalErrorCallback callback);

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
