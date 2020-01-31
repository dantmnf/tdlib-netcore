using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TDLib.JsonClient
{

    internal static class Crc32
    {
        private static readonly uint[] table;
        private const uint poly = 0xedb88320u;
        static Crc32()
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

        public static uint Update(uint crc, ReadOnlySpan<byte> input)
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

        public static uint Update(uint crc, byte input)
        {
            uint crcLocal = uint.MaxValue ^ crc;
            crcLocal = table[(byte)(crcLocal ^ input)] ^ crcLocal >> 8;
            return crcLocal ^ uint.MaxValue;
        }
    }

    internal class Crc32Stream : Stream
    {
        public uint Hash;

        public override bool CanRead => false;

        public override bool CanSeek => false;

        public override bool CanWrite => true;

        public override long Length => 0;

        public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void WriteByte(byte value)
        {
            Hash = Crc32.Update(Hash, value);
        }
        public override void Write(byte[] buf, int off, int len)
        {
            Hash = Crc32.Update(Hash, buf.AsSpan(off, len));
        }

        public override void Write(ReadOnlySpan<byte> buf)
        {
            Hash = Crc32.Update(Hash, buf);
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }
        
    }
}
