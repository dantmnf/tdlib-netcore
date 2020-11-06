using System;
using System.Collections.Generic;
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
    }
}
