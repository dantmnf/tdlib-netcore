#if ARM_INTRINSICS
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

using System.Runtime.Intrinsics.Arm;
#warning ARM CRC32C implementation is untested

namespace TDLibCore.JsonClient
{
    partial class Crc32C
    {
        unsafe static class ImplARM
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
            [MethodImpl(MethodImplOptions.AggressiveOptimization)]
            private static uint crc32Hardware32(uint crc, void* data, int length)
            {
                crc ^= uint.MaxValue;
                byte* p_buf = (byte*)data;
                // alignment matters on 32 bit ARM
                var unaligned = 4 - (int)((uint)p_buf - ((uint)p_buf & 3));
                switch (unaligned)
                {
                    case 3:
                        crc = Crc32.ComputeCrc32C(crc, (byte)*p_buf++);
                        goto case 2;
                    case 2:
                        crc = Crc32.ComputeCrc32C(crc, *(ushort*)p_buf);
                        p_buf += 2;
                        break;
                    case 1:
                        crc = Crc32.ComputeCrc32C(crc, (byte)*p_buf++);
                        break;
                    case 0:
                        break;
                    default:
                        // This should never happen; enable in debug code
                        Debug.Assert(false);
                        break;
                }
                p_buf += unaligned;
                length -= unaligned;

                for (int i = 0; i < length / sizeof(uint); i++)
                {
                    crc = Crc32.ComputeCrc32C(crc, *(uint*)p_buf);
                    p_buf += sizeof(uint);
                }

                // This ugly switch is slightly faster for short strings than the straightforward loop
                switch (length)
                {
                    case 3:
                        crc = Crc32.ComputeCrc32C(crc, (byte)*p_buf++);
                        goto case 2;
                    case 2:
                        crc = Crc32.ComputeCrc32C(crc, *(ushort*)p_buf);
                        break;
                    case 1:
                        crc = Crc32.ComputeCrc32C(crc, (byte)*p_buf);
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

            [MethodImpl(MethodImplOptions.AggressiveOptimization)]
            private static uint crc32Hardware64(uint crc, byte* data, int length)
            {
                crc ^= uint.MaxValue;
                var p_buf = data;
                uint crc32bit = crc;
                for (var i = 0; i < length / sizeof(ulong); i++)
                {
                    crc32bit = Crc32.Arm64.ComputeCrc32C(crc32bit, *(ulong*)p_buf);
                    p_buf += sizeof(ulong);
                }
                // This ugly switch is slightly faster for short strings than the straightforward loop
                length &= sizeof(ulong) - 1;
                switch (length)
                {
                    case 7:
                        crc32bit = Crc32.ComputeCrc32C(crc32bit, *p_buf++);
                        goto case 6;
                    case 6:
                        crc32bit = Crc32.ComputeCrc32C(crc32bit, *(ushort*)p_buf);
                        p_buf += 2;
                        goto case 4;
                    // case 5 is below: 4 + 1
                    case 4:
                        crc32bit = Crc32.ComputeCrc32C(crc32bit, *(uint*)p_buf);
                        break;
                    case 3:
                        crc32bit = Crc32.ComputeCrc32C(crc32bit, *p_buf++);
                        goto case 2;
                    case 2:
                        crc32bit = Crc32.ComputeCrc32C(crc32bit, *(ushort*)p_buf);
                        break;
                    case 5:
                        crc32bit = Crc32.ComputeCrc32C(crc32bit, *(uint*)p_buf);
                        p_buf += 4;
                        goto case 1;
                    case 1:
                        crc32bit = Crc32.ComputeCrc32C(crc32bit, *p_buf);
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
