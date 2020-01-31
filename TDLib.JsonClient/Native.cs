using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace TDLib.JsonClient
{
    static class Native
    {
        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_json_client_create();

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void td_json_client_send(IntPtr client, byte* request);
        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_json_client_send(IntPtr client, IntPtr request);

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_json_client_receive(IntPtr client, double timeout);

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_json_client_execute(IntPtr client, IntPtr request);
        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe byte* td_json_client_execute(IntPtr client, byte* request);

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_json_client_destroy(IntPtr client);

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern int td_set_log_file_path(IntPtr file_path);

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_set_log_max_file_size(long max_file_size);

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_set_log_verbosity_level(int new_verbosity_level);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void td_log_fatal_error_callback_ptr(IntPtr message);

        [DllImport("tdjson", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_set_log_fatal_error_callback(td_log_fatal_error_callback_ptr callback);

        public static unsafe int strlen(byte* str)
        {
            int result = 0;
            while (*str++ != 0) result++;
            return result;
        }
    }
}
