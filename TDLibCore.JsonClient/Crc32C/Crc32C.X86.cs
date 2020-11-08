#if X86_INTRINSICS
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

using System.Runtime.Intrinsics.X86;
using System.Runtime.InteropServices;

namespace TDLibCore.JsonClient
{
    partial class Crc32C
    {
        static class ImplX86
        {
            public static uint Update(uint crc, ReadOnlySpan<byte> input)
            {
                crc ^= uint.MaxValue;
                while (input.Length >= sizeof(uint))
                {
                    crc = Sse42.Crc32(crc, Unsafe.ReadUnaligned<uint>(ref MemoryMarshal.GetReference(input)));
                    input = input.Slice(sizeof(uint));
                }
                for (int i = 0; i < input.Length; i++)
                {
                    crc = Sse42.Crc32(crc, (byte)input[i]);
                }
                return crc ^ uint.MaxValue;
            }

            public static uint Update64(uint crc, ReadOnlySpan<byte> input)
            {
                ulong crcl = crc ^ uint.MaxValue;
                while (input.Length >= sizeof(ulong))
                {
                    crcl = Sse42.X64.Crc32(crcl, Unsafe.ReadUnaligned<ulong>(ref MemoryMarshal.GetReference(input)));
                    input = input.Slice(sizeof(ulong));
                }
                crc = unchecked((uint)crcl);
                if (input.Length >= 4)
                {
                    crc = Sse42.Crc32(crc, Unsafe.ReadUnaligned<uint>(ref MemoryMarshal.GetReference(input)));
                    input = input.Slice(sizeof(uint));
                }
                for (int i = 0; i < input.Length; i++)
                {
                    crc = Sse42.Crc32(crc, (byte)input[i]);
                }
                return crc ^ uint.MaxValue;
            }
        }
    }
}
#endif
