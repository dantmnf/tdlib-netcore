#if ARM_INTRINSICS
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace TDLibCore.JsonClient
{
    partial class Crc32C
    {
        unsafe static class ImplARM
        {
            public static uint Update(uint crc, ReadOnlySpan<byte> input)
            {
                while (input.Length >= 4)
                {
                    crc = Crc32.ComputeCrc32C(crc, Unsafe.ReadUnaligned<uint>(ref MemoryMarshal.GetReference(input)));
                    input = input.Slice(sizeof(uint));
                }
                for (int i = 0; i < input.Length; i++)
                {
                    crc = Crc32.ComputeCrc32C(crc, input[i]);
                }
                return crc;
            }

            public static uint Update64(uint crc, ReadOnlySpan<byte> input)
            {
                while (input.Length >= sizeof(ulong))
                {
                    crc = Crc32.Arm64.ComputeCrc32C(crc, Unsafe.ReadUnaligned<ulong>(ref MemoryMarshal.GetReference(input)));
                    input = input.Slice(sizeof(ulong));
                }
                if (input.Length >= 4)
                {
                    crc = Crc32.ComputeCrc32C(crc, Unsafe.ReadUnaligned<uint>(ref MemoryMarshal.GetReference(input)));
                    input = input.Slice(sizeof(uint));
                }
                for (int i = 0; i < input.Length; i++)
                {
                    crc = Crc32.ComputeCrc32C(crc, input[i]);
                }
                return crc;
            }
        }
    }
}
#endif
