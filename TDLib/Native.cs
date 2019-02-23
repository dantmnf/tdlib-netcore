using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;
#pragma warning disable IDE1006 // Naming Styles

namespace TDLib
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FatalErrorCallback([MarshalAs(UnmanagedType.LPUTF8Str)]string message);

    [SuppressUnmanagedCodeSecurity]
    static unsafe class Native
    {
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool td_bridge_log_set_file_path(byte* file_path, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_log_set_max_file_size(long max_file_size);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_log_set_verbosity_level(int new_verbosity_level);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_log_set_fatal_error_callback(FatalErrorCallback callback);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern int td_bridge_object_get_id(IntPtr obj);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_object_destroy(IntPtr client);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_client_create();
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_client_destroy(IntPtr client);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_client_send(IntPtr client, long id, IntPtr func);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_client_receive(IntPtr client, double timeout, out long id);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_client_execute(IntPtr client, long inid, IntPtr func, out long outid);

        public static unsafe int strlen(byte* str)
        {
            int result = 0;
            while (*str++ != 0) result++;
            return result;
        }
    }
}
