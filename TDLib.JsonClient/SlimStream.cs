using System;
using System.Buffers;
using System.IO;
using System.Runtime.CompilerServices;

namespace TDLib.JsonClient
{
    internal interface ISlimWriter
    {
        void Write(ReadOnlySpan<byte> span);
        void WriteByte(byte x);
    }

    internal struct SlimStreamWriter : ISlimWriter
    {
        readonly Stream stream;
        public SlimStreamWriter(Stream s)
        {
            stream = s;
        }
        public void Write(ReadOnlySpan<byte> span)
        {
            stream.Write(span);
        }

        public void WriteByte(byte x)
        {
            stream.WriteByte(x);
        }
    }

    internal struct NullSlimWriter : ISlimWriter
    {
        public void Write(ReadOnlySpan<byte> span)
        {
        }

        public void WriteByte(byte x)
        {
        }
    }

    internal struct BufferSlimWriter : ISlimWriter
    {
        private IBufferWriter<byte> writer;

        public BufferSlimWriter(IBufferWriter<byte> writer)
        {
            this.writer = writer;
        }
        public void Write(ReadOnlySpan<byte> span)
        {
            var dest = writer.GetSpan(span.Length);
            span.CopyTo(dest);
            writer.Advance(span.Length);
        }

        public void WriteByte(byte x)
        {
            var dest = writer.GetSpan(1);
            dest[0] = x;
            writer.Advance(1);
        }
    }
}
