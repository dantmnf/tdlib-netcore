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
            table = (uint*)Marshal.AllocHGlobal(16 * 256 * 4);
            InitializeTable(table);
            if (BitConverter.IsLittleEndian)
            {
                implptr = &UpdateLittleEndianOptimized;
                goto end_decision;
            }
            implptr = &UpdateNaive;
        end_decision:;
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

        static uint UpdateLittleEndianOptimized(uint crci, ReadOnlySpan<byte> input)
        {
            // Copyright (C) 2013 Mark Adler
            ulong crc;

            crc = crci ^ 0xffffffff;
            while (input.Length >= sizeof(ulong))
            {
                crc ^= Unsafe.ReadUnaligned<ulong>(ref MemoryMarshal.GetReference(input));
                crc = table[(7 * 256) + (crc & 0xff)] ^
                      table[(6 * 256) + ((crc >> 8) & 0xff)] ^
                      table[(5 * 256) + ((crc >> 16) & 0xff)] ^
                      table[(4 * 256) + ((crc >> 24) & 0xff)] ^
                      table[(3 * 256) + ((crc >> 32) & 0xff)] ^
                      table[(2 * 256) + ((crc >> 40) & 0xff)] ^
                      table[(1 * 256) + ((crc >> 48) & 0xff)] ^
                      table[(0 * 256) + (crc >> 56)];
                input = input.Slice(sizeof(ulong));
            }
            for (int i = 0; i < input.Length; i++)
            {
                crc = table[(0 * 256) + ((crc ^ input[i]) & 0xff)] ^ (crc >> 8);
            }
            return (uint)crc ^ 0xffffffff;
        }

        static uint UpdateNaive(uint crc, ReadOnlySpan<byte> input)
        {
            crc ^= uint.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                crc = table[(0 * 256) + ((crc ^ input[i]) & 0xff)] ^ (crc >> 8);
            }
            return crc ^ uint.MaxValue;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Update(uint crc, ReadOnlySpan<byte> input) => implptr(crc, input);

    }
}
