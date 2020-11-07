using System;
using System.Collections.Generic;
using System.Text;

namespace TDLibCore.JsonClient
{
    static class MultiTargetHelper
    {
        public static byte[] AllocArray(int size)
        {
#if NET5_0
            return GC.AllocateUninitializedArray<byte>(size, false);
#else
            return new byte[size];
#endif
        }

#if NETSTANDARD2_0
        public static unsafe string GetString(this Encoding enc, ReadOnlySpan<byte> s)
        {
            fixed (byte* ptr = s)
            {
                return enc.GetString(ptr, s.Length);
            }
        }
#endif
    }
}
