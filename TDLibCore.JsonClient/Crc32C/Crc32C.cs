using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if X86_INTRINSICS
using System.Runtime.Intrinsics.X86;
#endif
#if ARM_INTRINSICS
using System.Runtime.Intrinsics.Arm;
#endif

namespace TDLibCore.JsonClient
{

    internal static unsafe partial class Crc32C
    {

        private static readonly uint* table;
        private const uint poly = 0x82f63b78u;
        private static delegate*<uint, ReadOnlySpan<byte>, uint> implptr;
        static Crc32C()
        {
#if X86_INTRINSICS
            if (Sse42.X64.IsSupported)
            {
                implptr = &ImplX86.Update64;
                goto end_decision;
            }
            if (Sse42.IsSupported)
            {
                implptr = &ImplX86.Update;
                goto end_decision;
            }
#endif
#if ARM_INTRINSICS
            if (Crc32.Arm64.IsSupported)
            {
                implptr = &ImplARM.Update64;
                goto end_decision;
            }
            if (Crc32.IsSupported)
            {
                implptr = &ImplARM.Update;
                goto end_decision;
            }
#endif
            if (BitConverter.IsLittleEndian)
            {
                implptr = &UpdateLittleEndianOptimized;
                goto end_decision;
            }
            implptr = &UpdateNaive;
            end_decision:
            
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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


        internal static uint UpdateLittleEndianOptimized(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            var len = inputSpan.Length;
            fixed (byte* input = inputSpan)
            {
                return crc32c_sw(crc, input, inputSpan.Length);
            }
        }

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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Update(uint crc, ReadOnlySpan<byte> input) => implptr(crc, input);

    }
}
