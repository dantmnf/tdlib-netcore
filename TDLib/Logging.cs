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
        public delegate void FatalErrorCallbackPtr(IntPtr message);

        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_log_set_fatal_error_callback(FatalErrorCallbackPtr callback);

        private static int loglevelvalue = 5;
        private static Action<string> usercallback;
        private static FatalErrorCallbackPtr mappedcallback;
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
            if(path == null)
            {
                return td_bridge_log_set_file_path(null, 0);
            }
            else
            {
                var utf8bytes = new byte[Encoding.UTF8.GetByteCount(path) + 1];
                Encoding.UTF8.GetBytes(path, 0, path.Length, utf8bytes, 0);
                fixed (byte* cstr = utf8bytes)
                    return td_bridge_log_set_file_path(cstr, utf8bytes.LongLength);
            }
        }

        public static void SetLogMaxFileSize(long maxsize)
        {
            td_bridge_log_set_max_file_size(maxsize);
        }

        public static void SetLogFatalErrorCallback(Action<string> callback)
        {
            usercallback = callback;
            mappedcallback = cstrptr =>
            {
                var cstr = (byte*)cstrptr;
                var netstr = Encoding.UTF8.GetString(cstr, strlen(cstr));
                usercallback(netstr);
            };
            td_bridge_log_set_fatal_error_callback(mappedcallback);
        }
    }
}
