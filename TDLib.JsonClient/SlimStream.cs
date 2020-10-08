using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace TDLib.JsonClient
{
    public interface ISlimStreamWriter
    {
        void Write(ReadOnlySpan<byte> span);
        void WriteByte(byte x);
    }

    public class SlimStreamWrapper : ISlimStreamWriter
    {
        readonly Stream stream;
        public SlimStreamWrapper(Stream s)
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

    public struct NullSlimStream : ISlimStreamWriter
    {
        public void Write(ReadOnlySpan<byte> span)
        {
        }

        public void WriteByte(byte x)
        {
        }
    }

    public unsafe struct SlimMemoryStream : ISlimStreamWriter
    {
        private byte* fixedbuffer;
        private int fixedbufferlength;
        internal byte[] gcbuffer;
        private int lengthValue;
        public int Length => lengthValue;

        private readonly int RemainingCapacity => gcbuffer switch
        {
            null => fixedbuffer switch
            {
                null => 0,
                _ => fixedbufferlength - lengthValue,
            },
            _ => gcbuffer.Length - lengthValue,
        };

        public SlimMemoryStream(int capacity)
        {
            gcbuffer = new byte[capacity];
            fixedbuffer = null;
            fixedbufferlength = 0;
            lengthValue = 0;
        }

        public SlimMemoryStream(byte* initialFixedBuffer, int length)
        {
            fixedbuffer = initialFixedBuffer;
            fixedbufferlength = length;
            gcbuffer = initialFixedBuffer == null ? new byte[256] : null;
            lengthValue = 0;
        }

        private void ExpandBuffer(int minLength)
        {
            int newcap;
            ReadOnlySpan<byte> srcSpan;
            if (fixedbuffer != null)
            {
                // called in EnsureRemainingCpacity, need to allocate GC buffer
                srcSpan = new Span<byte>(fixedbuffer, fixedbufferlength);
                newcap = fixedbufferlength + minLength;
            }
            else
            {
                srcSpan = gcbuffer.AsSpan().Slice(0, lengthValue);
                newcap = gcbuffer.Length + minLength;
            }
            newcap = (newcap + 255) & (~255);
            var newbuf = new byte[newcap];
            //Buffer.BlockCopy(buffer, 0, newbuf, 0, buffer.Length);
            srcSpan.CopyTo(newbuf);
            gcbuffer = newbuf;
            if (fixedbuffer != null)
            {
                fixedbuffer = null;
                fixedbufferlength = 0;
            }
        }

        public void PromoteToGCHeap()
        {
            if (fixedbuffer != null)
            {
                gcbuffer = new Span<byte>(fixedbuffer, fixedbufferlength).ToArray();
                fixedbuffer = null;
                fixedbufferlength = 0;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void EnsureRemainingCpacity(int length)
        {
            if (RemainingCapacity >= length) return;
            ExpandBuffer(length);
        }

        public void Write(ReadOnlySpan<byte> span)
        {
            EnsureRemainingCpacity(span.Length);
            var buffer = fixedbuffer != null ? new Span<byte>(fixedbuffer, fixedbufferlength) : gcbuffer;
            span.CopyTo(buffer.Slice(lengthValue));
            lengthValue += span.Length;
        }

        public void WriteByte(byte x)
        {
            EnsureRemainingCpacity(1);
            var buffer = fixedbuffer != null ? new Span<byte>(fixedbuffer, fixedbufferlength) : gcbuffer;
            buffer[lengthValue] = x;
            lengthValue += 1;
        }

        public Span<byte> GetSpan()
        {
            var buffer = fixedbuffer != null ? new Span<byte>(fixedbuffer, fixedbufferlength) : gcbuffer;
            return buffer.Slice(0, lengthValue);
        }

        public ReadOnlySpan<byte> GetReadOnlySpan() => GetSpan();

    }
}
