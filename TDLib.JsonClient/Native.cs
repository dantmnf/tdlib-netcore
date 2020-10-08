using System;
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

        public static unsafe UIntPtr strlen(byte* str)
        {
            var end = str;
            while (*end++ != 0) ;
            return (UIntPtr)(end - str - 1);
        }

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //[return: MarshalAs(UnmanagedType.SysUInt)]
        //public unsafe delegate UIntPtr strlen_t(byte* str);

        //public static strlen_t strlen;
        //unsafe static Native() {
        //    strlen = strlen_managed;
        //    switch (Environment.OSVersion.Platform)
        //    {
        //        case PlatformID.Win32NT:
        //            {
        //                if (NativeLibrary.TryLoad("api-ms-win-crt-string-l1-1-0.dll", out var lib))
        //                    if (NativeLibrary.TryGetExport(lib, "strlen", out var func))
        //                    {
        //                        strlen = Marshal.GetDelegateForFunctionPointer<strlen_t>(func);
        //                        Console.WriteLine("using crt strlen");
        //                    }
        //            }
        //            break;
        //        case PlatformID.Unix:
        //            {
        //                if (NativeLibrary.TryGetExport(IntPtr.Zero, "strlen", out var func)) // RTLD_DEFAULT
        //                    strlen = Marshal.GetDelegateForFunctionPointer<strlen_t>(func);
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}

    }
}
