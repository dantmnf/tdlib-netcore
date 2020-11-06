#if X86_INTRINSICS
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

using System.Runtime.Intrinsics.X86;

namespace TDLibCore.JsonClient
{
    partial class Crc32C
    {
        public unsafe static class ImplX86
        {
            internal static uint Update(uint crc, ReadOnlySpan<byte> inputSpan)
            {
                fixed (byte* input = inputSpan)
                {
                    return crc32Hardware32(crc, input, inputSpan.Length);
                }
            }

            internal static uint Update64(uint crc, ReadOnlySpan<byte> inputSpan)
            {
                fixed (byte* input = inputSpan)
                {
                    return crc32Hardware64(crc, input, inputSpan.Length);
                }
            }

            // Copyright 2008,2009,2010 Massachusetts Institute of Technology.
            // from https://github.com/htot/crc32c/blob/022db995990418e1b581b6bf5f843bb775348e34/crc32c/crc32c.cc#L141
            private static uint crc32Hardware32(uint crc, void* data, int length)
            {
                crc ^= uint.MaxValue;
                byte* p_buf = (byte*)data;
                // alignment doesn't seem to help?
                for (int i = 0; i < length / sizeof(uint); i++)
                {
                    crc = Sse42.Crc32(crc, *(uint*)p_buf);
                    p_buf += sizeof(uint);
                }

                // This ugly switch is slightly faster for short strings than the straightforward loop
                length &= sizeof(uint) - 1;
                /*
                while (length > 0) {
                    crc32bit = __builtin_ia32_crc32qi(crc32bit, *p_buf++);
                    length--;
                }
                */
                switch (length)
                {
                    case 3:
                        crc = Sse42.Crc32(crc, (byte)*p_buf++);
                        goto case 2;
                    case 2:
                        crc = Sse42.Crc32(crc, *(ushort*)p_buf);
                        break;
                    case 1:
                        crc = Sse42.Crc32(crc, (byte)*p_buf);
                        break;
                    case 0:
                        break;
                    default:
                        // This should never happen; enable in debug code
                        Debug.Assert(false);
                        break;
                }

                return crc ^ uint.MaxValue;
            }

            private static uint crc32Hardware64(uint crc, byte* data, int length)
            {
                crc ^= uint.MaxValue;
                var p_buf = data;
                ulong crc64bit = crc;
                for (var i = 0; i < length / sizeof(ulong); i++)
                {
                    crc64bit = Sse42.X64.Crc32(crc64bit, *(ulong*)p_buf);
                    p_buf += sizeof(ulong);
                }
                // This ugly switch is slightly faster for short strings than the straightforward loop
                var crc32bit = (uint)crc64bit;
                length &= sizeof(ulong) - 1;
                switch (length)
                {
                    case 7:
                        crc32bit = Sse42.Crc32(crc32bit, *p_buf++);
                        goto case 6;
                    case 6:
                        crc32bit = Sse42.Crc32(crc32bit, *(ushort*)p_buf);
                        p_buf += 2;
                        goto case 4;
                    // case 5 is below: 4 + 1
                    case 4:
                        crc32bit = Sse42.Crc32(crc32bit, *(uint*)p_buf);
                        break;
                    case 3:
                        crc32bit = Sse42.Crc32(crc32bit, *p_buf++);
                        goto case 2;
                    case 2:
                        crc32bit = Sse42.Crc32(crc32bit, *(ushort*)p_buf);
                        break;
                    case 5:
                        crc32bit = Sse42.Crc32(crc32bit, *(uint*)p_buf);
                        p_buf += 4;
                        goto case 1;
                    case 1:
                        crc32bit = Sse42.Crc32(crc32bit, *p_buf);
                        break;
                    case 0:
                        break;
                    default:
                        // This should never happen; enable in debug code
                        Debug.Assert(false);
                        break;
                }

                return crc32bit ^ uint.MaxValue;
            }
        }
    }


}
#endif
