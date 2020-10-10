using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace TDLib.JsonClient
{
    internal static unsafe class Crc32C
    {
        private static readonly uint* table;
        private const uint poly = 0x82f63b78u;

        enum ImplType { Naive, LittleEndianOptimized, Sse42, Sse42_64 }
        private static readonly ImplType impl;

        static Crc32C()
        {
            int one = 1;
            var little_endian = *(byte*)&one != 0;
            if (Sse42.X64.IsSupported)
            {
                impl = ImplType.Sse42_64;
            }
            else if (Sse42.IsSupported)
            {
                impl = ImplType.Sse42;
            }
            else if (little_endian)
            {
                impl = ImplType.LittleEndianOptimized;
            }
            else
            {
                impl = ImplType.Naive;
            }

            table = (uint*)Marshal.AllocHGlobal(16 * 256 * 4);
            crc32c_init_sw();
        }

        static void crc32c_init_sw()
        {
            for (uint i = 0; i < 256; i++)
            {
                uint res = i;
                for (int t = 0; t < 16; t++)
                {
                    for (int k = 0; k < 8; k++) res = (res & 1) == 1 ? poly ^ (res >> 1) : (res >> 1);
                    table[(t * 256) + i] = res;
                }
            }
        }

        // Copyright (C) 2013 Mark Adler
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
        static uint crc32c_sw(uint crci, void* buf, int len)
        {
            byte* next = (byte*)buf;
            ulong crc;

            crc = crci ^ 0xffffffff;
            while (len != 0 && ((ulong)next & 7) != 0)
            {
                crc = table[(0 * 256) + ((crc ^ *next++) & 0xff)] ^ (crc >> 8);
                len--;
            }
            while (len >= 8)
            {
                crc ^= *(ulong*)next;
                crc = table[(7 * 256) + (crc & 0xff)] ^
                      table[(6 * 256) + ((crc >> 8) & 0xff)] ^
                      table[(5 * 256) + ((crc >> 16) & 0xff)] ^
                      table[(4 * 256) + ((crc >> 24) & 0xff)] ^
                      table[(3 * 256) + ((crc >> 32) & 0xff)] ^
                      table[(2 * 256) + ((crc >> 40) & 0xff)] ^
                      table[(1 * 256) + ((crc >> 48) & 0xff)] ^
                      table[(0 * 256) + (crc >> 56)];
                next += 8;
                len -= 8;
            }
            while (len != 0)
            {
                crc = table[(0 * 256) + ((crc ^ *next++) & 0xff)] ^ (crc >> 8);
                len--;
            }
            return (uint)crc ^ 0xffffffff;
        }


        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        internal static uint UpdateX86(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            fixed (byte* input = inputSpan)
            {
                return crc32Hardware32(crc, input, inputSpan.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        internal static uint UpdateX86_64(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            fixed (byte* input = inputSpan)
            {
                return crc32Hardware64(crc, input, inputSpan.Length);
            }
        }

        #region hardware CRC32C implementation
        // Copyright 2008,2009,2010 Massachusetts Institute of Technology.
        // from https://github.com/htot/crc32c/blob/022db995990418e1b581b6bf5f843bb775348e34/crc32c/crc32c.cc#L141
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
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

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
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
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        internal static uint UpdateLittleEndianOptimized(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            var len = inputSpan.Length;
            fixed (byte* input = inputSpan)
            {
                return crc32c_sw(crc, input, inputSpan.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        internal static uint UpdateNaive(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            crc ^= uint.MaxValue;
            var len = inputSpan.Length;
            fixed (byte* input = inputSpan)
            {
                var next = input;
                while (len != 0)
                {
                    crc = table[(0 * 256) + ((crc ^ *next++) & 0xff)] ^ (crc >> 8);
                    len--;
                }
            }
            return crc ^ uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public static uint Update(uint crc, ReadOnlySpan<byte> input)
        {
            return impl switch
            {
                ImplType.Sse42_64 => UpdateX86_64(crc, input),
                ImplType.Sse42 => UpdateX86(crc, input),
                ImplType.LittleEndianOptimized => UpdateLittleEndianOptimized(crc, input),
                ImplType.Naive => UpdateNaive(crc, input),
                _ => 0,
            };
        }
    }
}
