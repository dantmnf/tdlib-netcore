using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TDLibCore.JsonClient
{
    static class Hash
    {
        public static uint FNV1a(ReadOnlySpan<byte> input)
        {
            var hash = 2166136261u;
            for (int i = 0; i < input.Length; i++)
            {
                var octet = input[i];
                hash ^= octet;
                hash *= 16777619;
            }
            return hash;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint CRC32C(ReadOnlySpan<byte> input) => Crc32C.Update(0, input);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ComputeHash(ReadOnlySpan<byte> input) => CRC32C(input);
    }
}
