using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TDLib.JsonClient
{
    internal static unsafe partial class Crc32C
    {
        private static readonly uint* table;
        private const uint poly = 0x82f63b78u;
        enum ImplType { Naive, LittleEndianOptimized, Sse42, Sse42_64, ARM, ARM_64 }
        private static readonly ImplType impl;

        static Crc32C()
        {
            int one = 1;
            var little_endian = *(byte*)&one != 0;
#pragma warning disable CS0162
            if (ImplX86.Supported64)
            {
                impl = ImplType.Sse42_64;
            }
            else if (ImplX86.Supported)
            {
                impl = ImplType.Sse42;
            }
            else if (ImplARM.Supported64)
            {
                impl = ImplType.ARM_64;
            }
            else if (ImplARM.Supported)
            {
                impl = ImplType.ARM;
            }
            else if (little_endian)
            {
                impl = ImplType.LittleEndianOptimized;
            }
            else
            {
                impl = ImplType.Naive;
            }
#pragma warning restore CS0162

            table = (uint*)Marshal.AllocHGlobal(16 * 256 * 4);
            InitializeTable(table);
        }

        static void InitializeTable(uint* table)
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

        [MethodImpl(MultiTargetHelper.MethodImplOptions_AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
        static uint crc32c_sw(uint crci, void* buf, int len)
        {
            // Copyright (C) 2013 Mark Adler
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


        [MethodImpl(MultiTargetHelper.MethodImplOptions_AggressiveOptimization)]
        internal static uint UpdateLittleEndianOptimized(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            var len = inputSpan.Length;
            fixed (byte* input = inputSpan)
            {
                return crc32c_sw(crc, input, inputSpan.Length);
            }
        }

        [MethodImpl(MultiTargetHelper.MethodImplOptions_AggressiveOptimization)]
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

        [MethodImpl(MultiTargetHelper.MethodImplOptions_AggressiveOptimization)]
        public static uint Update(uint crc, ReadOnlySpan<byte> input)
        {
            return impl switch
            {
#if X86_INTRINSICS
                ImplType.Sse42_64 => ImplX86.Update64(crc, input),
#endif
#if ARM_INTRINSICS
                ImplType.ARM_64 => ImplARM.Update64(crc, input),
#endif
#if X86_INTRINSICS
                ImplType.Sse42 => ImplX86.Update(crc, input),
#endif
#if ARM_INTRINSICS
                ImplType.ARM => ImplARM.Update(crc, input),
#endif
                ImplType.LittleEndianOptimized => UpdateLittleEndianOptimized(crc, input),
                ImplType.Naive => UpdateNaive(crc, input),
                _ => 0,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Calcuate(ReadOnlySpan<byte> input) => Update(0, input);
    }
}
