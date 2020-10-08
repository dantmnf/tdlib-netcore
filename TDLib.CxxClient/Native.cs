using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using TDLib.CxxClient.CxxInterop;
#pragma warning disable IDE1006 // Naming Styles

namespace TDLib.CxxClient
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FatalErrorCallback(IntPtr message);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FetchObjectCallback(IntPtr obj, long id);

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
        public static extern void td_bridge_object_destroy(IntPtr obj);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_object_ptr_get(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_object_ptr_reset(IntPtr ptr, IntPtr obj);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_client_create();
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_client_destroy(IntPtr client);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_client_send(IntPtr client, long id, IntPtr func);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_client_receive(IntPtr client, double timeout, FetchObjectCallback callback);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_client_execute(IntPtr client, long inid, IntPtr func, FetchObjectCallback callback);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_vector_vector_object_at(IntPtr ptr, long index);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern long td_bridge_vector_vector_object_size(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_vector_vector_object_emplace_back(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_vector_object_clear(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* td_bridge_string_data(IntPtr ptr, out long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_string_setdata(IntPtr ptr, byte* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* td_bridge_vector_int32_data(IntPtr ptr, out long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_int32_assign(IntPtr ptr, int* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* td_bridge_vector_int64_data(IntPtr ptr, out long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_int64_assign(IntPtr ptr, long* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_vector_object_at(IntPtr ptr, long index);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern long td_bridge_vector_object_size(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_object_emplace_back(IntPtr ptr, IntPtr obj);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_object_clear(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern CxxBytes td_bridge_vector_string_at(IntPtr ptr, long index);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern long td_bridge_vector_string_size(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_string_emplace_back(IntPtr ptr, byte* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_string_clear(IntPtr ptr);
        public static unsafe int strlen(byte* str)
        {
            int result = 0;
            while (*str++ != 0) result++;
            return result;
        }

        public static string SpanToUTF8String(ReadOnlySpan<byte> span)
        {
            if (span.Length == 0) return string.Empty;
            fixed (byte* buf = span)
                return Encoding.UTF8.GetString(buf, span.Length);
        }
    }
}
