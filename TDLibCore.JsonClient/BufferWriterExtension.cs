using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TDLibCore.JsonClient
{
    static class BufferWriterExtension
    {
        public static void WriteByte(this IBufferWriter<byte> writer, byte x)
        {
            var span = writer.GetSpan(1);
            span[0] = x;
            writer.Advance(1);
        }
    }
}
