using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TDLib.JsonClient
{
    internal static unsafe class Crc32C
    {
        private static readonly uint[] table;
        private const uint poly = 0x82f63b78;

        private static readonly bool sse42_x64 = Sse42.X64.IsSupported;
        private static readonly bool sse42 = Sse42.IsSupported;


        static Crc32C()
        {
            table = new uint[16 * 256];
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


        internal static uint UpdateX86(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            uint crcLocal = uint.MaxValue ^ crc;
            var length = inputSpan.Length;
            var offset = 0;
            fixed(byte* input = inputSpan)
            {
                while (length >= 4)
                {
                    crcLocal = Sse42.Crc32(crcLocal, *(uint*)(input + offset));
                    offset += 4;
                    length -= 4;
                }
                while (--length >= 0)
                    crcLocal = Sse42.Crc32(crcLocal, input[offset++]);
            }
            return crcLocal ^ uint.MaxValue;
        }

        internal static uint UpdateX86_64(uint crc, ReadOnlySpan<byte> inputSpan)
        {
            uint crcLocal = uint.MaxValue ^ crc;
            var length = inputSpan.Length;
            var offset = 0;
            fixed (byte* input = inputSpan)
            {
                while (length >= 8)
                {
                    crcLocal = (uint)Sse42.X64.Crc32(crcLocal, *(ulong*)(input + offset));
                    offset += 8;
                    length -= 8;
                }
                if (length >= 4)
                {
                    crcLocal = Sse42.Crc32(crcLocal, *(uint*)(input + offset));
                    offset += 4;
                    length -= 4;
                }
                while (--length >= 0)
                    crcLocal = Sse42.Crc32(crcLocal, input[offset++]);
            }
            return crcLocal ^ uint.MaxValue;
        }

        internal static uint UpdateManaged(uint crc, ReadOnlySpan<byte> input)
        {
            uint crcLocal = uint.MaxValue ^ crc;
            var length = input.Length;
            var offset = 0;
            
            while (length >= 16)
            {
                var a = table[(3 * 256) + input[offset + 12]]
                    ^ table[(2 * 256) + input[offset + 13]]
                    ^ table[(1 * 256) + input[offset + 14]]
                    ^ table[(0 * 256) + input[offset + 15]];

                var b = table[(7 * 256) + input[offset + 8]]
                    ^ table[(6 * 256) + input[offset + 9]]
                    ^ table[(5 * 256) + input[offset + 10]]
                    ^ table[(4 * 256) + input[offset + 11]];

                var c = table[(11 * 256) + input[offset + 4]]
                    ^ table[(10 * 256) + input[offset + 5]]
                    ^ table[(9 * 256) + input[offset + 6]]
                    ^ table[(8 * 256) + input[offset + 7]];

                var d = table[(15 * 256) + ((byte)crcLocal ^ input[offset])]
                    ^ table[(14 * 256) + ((byte)(crcLocal >> 8) ^ input[offset + 1])]
                    ^ table[(13 * 256) + ((byte)(crcLocal >> 16) ^ input[offset + 2])]
                    ^ table[(12 * 256) + ((crcLocal >> 24) ^ input[offset + 3])];

                crcLocal = d ^ c ^ b ^ a;
                offset += 16;
                length -= 16;
            }

            while (--length >= 0)
                crcLocal = table[(byte)(crcLocal ^ input[offset++])] ^ crcLocal >> 8;

            return crcLocal ^ uint.MaxValue;
        }

        public static uint Update(uint crc, ReadOnlySpan<byte> input)
        {
            if (sse42_x64) return UpdateX86_64(crc, input);
            if (sse42) return UpdateX86(crc, input);
            return UpdateManaged(crc, input);
        }
    }

    internal unsafe struct Crc32CStream : ISlimStreamWriter
    {
        public uint Hash;

        public static Crc32CStream Create() => new Crc32CStream();
        public void WriteByte(byte value)
        {
            Hash = Crc32C.Update(Hash, new ReadOnlySpan<byte>(&value, 1));
        }
        public void Write(ReadOnlySpan<byte> buf)
        {
            Hash = Crc32C.Update(Hash, buf);
        }
    }
}
