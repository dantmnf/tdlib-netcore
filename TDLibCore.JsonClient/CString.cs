using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TDLibCore.JsonClient
{
    static unsafe class CString
    {
        private static readonly delegate*<byte*, int> strlen_fn;
        private static readonly delegate*<IntPtr, nuint> libc_strlen_fn;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int strlen(byte* str) => strlen_fn(str);

        private static int libc_strlen_wrapper(byte* str) => (int)libc_strlen_fn((IntPtr)str);

        [DllImport("libc", EntryPoint = "gnu_get_libc_version", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr gnu_get_libc_version_netcore();

        [DllImport("__Internal", EntryPoint = "gnu_get_libc_version", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr gnu_get_libc_version_mono();

        [DllImport("libc", EntryPoint = "strlen", CallingConvention = CallingConvention.Cdecl)]
        private static extern nuint strlen_libc_netcore(IntPtr str);

        [DllImport("__Internal", EntryPoint = "strlen", CallingConvention = CallingConvention.Cdecl)]
        private static extern nuint strlen_libc_mono(IntPtr str);

        [DllImport("api-ms-win-crt-string-l1-1-0", EntryPoint = "strlen", CallingConvention = CallingConvention.Cdecl)]
        private static extern nuint strlen_win_ucrt(IntPtr str);

        static CString()
        {
            if (IsSystemStrlenFaster() && TryGetLibcStrlen(out var libcstrlen))
            {
                Debug.WriteLine("using libc strlen");
                libc_strlen_fn = (delegate*<IntPtr, nuint>)libcstrlen;
                strlen_fn = &libc_strlen_wrapper;
            }
            else if (TryGetFrameworkStrlen(out var fwstrlen))
            {
                Debug.WriteLine("using framework strlen");
                strlen_fn = (delegate*<byte*, int>)fwstrlen;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Debug.WriteLine("using ucrt strlen");
                libc_strlen_fn = &strlen_win_ucrt;
                strlen_fn = &libc_strlen_wrapper;
            }
            else
            {
                Debug.WriteLine("using naive strlen");
                strlen_fn = &strlen_naive;
            }
        }

        private static bool IsSystemStrlenFaster()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return true;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return IsGlibc();
            return false;
        }

        private static bool IsGlibc() => TryPrelink(new Func<IntPtr>(gnu_get_libc_version_netcore).Method)
                                        || TryPrelink(new Func<IntPtr>(gnu_get_libc_version_mono).Method);


        private static bool TryGetLibcStrlen(out IntPtr addr)
        {
            var method = new Func<IntPtr, nuint>(strlen_libc_netcore).Method;
            if (TryPrelink(method))
            {
                addr = (IntPtr)(delegate*<IntPtr, nuint>)&strlen_libc_netcore;
                return true;
            }
            method = new Func<IntPtr, nuint>(strlen_libc_mono).Method;
            if (TryPrelink(method))
            {
                addr = (IntPtr)(delegate*<IntPtr, nuint>)&strlen_libc_mono;
                return true;
            }
            addr = IntPtr.Zero;
            return false;
        }

        private static bool TryPrelink(MethodInfo m)
        {
            try
            {
                Marshal.Prelink(m);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool TryGetFrameworkStrlen(out IntPtr addr)
        {
            // FIXME: https://github.com/dotnet/runtime/issues/40202
            var fwstrlen = typeof(string).GetMethod("strlen", BindingFlags.Static | BindingFlags.NonPublic, Type.DefaultBinder, new[] { typeof(byte*) }, null);
            if (fwstrlen != null)
            {
                // This is the strlen implementation used in Marshal.PtrToStringUtf8(IntPtr).
                // It's roughly equivalent to
                // new ReadOnlySpan<byte>(ptr, int.MaxValue).IndexOf((byte)0)
                // with optimized IndexOf and assumption that it won't run into memory protection issues.
                // It's OK to assume that in framework, but we can't assume framework behavior here.
                addr = fwstrlen.MethodHandle.GetFunctionPointer();
                return true;
            }
            addr = IntPtr.Zero;
            return false;
        }

        public static int strlen_naive(byte* str)
        {
            var end = str;
            while (*end++ != 0) ;
            return (int)(end - str - 1);
        }
    }
}
