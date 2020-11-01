using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace TDLib.JsonClient
{
    static unsafe class CString
    {
        private static readonly delegate*<byte*, int> strlen_fn;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int strlen(byte* str) => strlen_fn(str);

        static CString()
        {
            var fwstrlen = typeof(string).GetMethod("strlen", BindingFlags.Static | BindingFlags.NonPublic, null, CallingConventions.Standard, new []{typeof(int*)}, null);
            if (fwstrlen != null)
            {
                // This is the strlen implementation used in Marshal.PtrToStringUtf8(IntPtr).
                // It's roughly equivalent to
                // new ReadOnlySpan<byte>(ptr, int.MaxValue).IndexOf((byte)0)
                // with optimized IndexOf and assumption that it won't run into memory protection issues.
                // It's OK to assume that in framework, but we can't assume framework behavior here.
                strlen_fn = (delegate*<byte*, int>)fwstrlen.MethodHandle.GetFunctionPointer();
            }
            else
            {
                // fallback to naive but safe implementation as we have no portable way to call libc strlen in .NET Standard
                strlen_fn = &strlen_naive;
            }
        }

        public static int strlen_naive(byte* str)
        {
            var end = str;
            while (*end++ != 0) ;
            return (int)(end - str - 1);
        }
    }
}
