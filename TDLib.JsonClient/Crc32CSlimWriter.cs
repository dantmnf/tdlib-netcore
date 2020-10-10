using System;

namespace TDLib.JsonClient
{
    internal unsafe struct Crc32CSlimWriter : ISlimWriter
    {
        public uint Hash;
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
