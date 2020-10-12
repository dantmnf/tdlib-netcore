using System;
using System.Buffers;
using System.Buffers.Text;
using System.IO;
using TDLib.Api;

namespace TDLib.JsonClient
{
    internal partial class TdJsonWriter
    {
        // partial const int _extrapos;
        // partial const int _extralen;
        private static readonly byte[] TrueValue = { (byte)'t', (byte)'r', (byte)'u', (byte)'e' };
        private static readonly byte[] FalseValue = { (byte)'f', (byte)'a', (byte)'l', (byte)'s', (byte)'e' };
        private static readonly byte[] NullValue = { (byte)'n', (byte)'u', (byte)'l', (byte)'l' };
        private static readonly byte[] EmptyString = { (byte)'"', (byte)'"' };
        private static readonly byte[] EmptyArray = { (byte)'[', (byte)']' };
        private static readonly byte[] BackSlash_b = { (byte)'\\', (byte)'b' };
        private static readonly byte[] BackSlash_f = { (byte)'\\', (byte)'f' };
        private static readonly byte[] BackSlash_n = { (byte)'\\', (byte)'n' };
        private static readonly byte[] BackSlash_r = { (byte)'\\', (byte)'r' };
        private static readonly byte[] BackSlash_t = { (byte)'\\', (byte)'t' };
        private static readonly byte[] BackSlash_u = { (byte)'\\', (byte)'u' };
        private static readonly byte[] BackSlash_BackSlash = { (byte)'\\', (byte)'\\' };
        private static readonly byte[] BackSlash_DoubleQuote = { (byte)'\\', (byte)'"' };
        private static readonly byte[] HexMap = { (byte)'0', (byte)'1', (byte)'2', (byte)'3', (byte)'4', (byte)'5', (byte)'6', (byte)'7',
                                                  (byte)'8', (byte)'9', (byte)'A', (byte)'B', (byte)'C', (byte)'D', (byte)'E', (byte)'F'};


        private IBufferWriter<byte> writer;

        public TdJsonWriter(IBufferWriter<byte> writer)
        {
            this.writer = writer;
        }
        public void WriteSpan(ReadOnlySpan<byte> span)
        {
            var dest = writer.GetSpan(span.Length);
            span.CopyTo(dest);
            writer.Advance(span.Length);
        }

        protected void WriteOutputByte(byte value)
        {
            var dest = writer.GetSpan(1);
            dest[0] = value;
            writer.Advance(1);
        }


        public void WriteValue(long value)
        {
            var span = writer.GetSpan(32);
            Utf8Formatter.TryFormat(value, span, out var written);
            writer.Advance(written);
        }

        public void WriteValue(ulong value)
        {
            var span = writer.GetSpan(32);
            Utf8Formatter.TryFormat(value, span, out var written);
            writer.Advance(written);
        }

        public void WriteValue(double value)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
            {
                WriteNull();
            }
            else
            {
                var span = writer.GetSpan(32);
                Utf8Formatter.TryFormat(value, span, out var written);
                writer.Advance(written);
            }
        }

        public void WriteValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                WriteSpan(EmptyString);
                return;
            }
            WriteOutputByte((byte)'"');

            for (int i = 0; i < value.Length; i++)
            {
                var chr = value[i];

                switch (chr)
                {
                    case '\b':
                        WriteSpan(BackSlash_b);
                        break;
                    case '\f':
                        WriteSpan(BackSlash_f);
                        break;
                    case '\n':
                        WriteSpan(BackSlash_n);
                        break;
                    case '\r':
                        WriteSpan(BackSlash_r);
                        break;
                    case '\t':
                        WriteSpan(BackSlash_t);
                        break;
                    case '\"':
                        WriteSpan(BackSlash_DoubleQuote);
                        break;
                    case '\\':
                        WriteSpan(BackSlash_BackSlash);
                        break;
                    default:
                    {
                        if (chr >= 0x20 && chr <= 0x7E)
                        {
                            WriteOutputByte((byte)chr);
                        }
                        else
                        {
                            var x = (int) chr;
                            var span = writer.GetSpan(6);
                            BackSlash_u.CopyTo(span);
                            span[2] = HexMap[(x >> 12) & 0xF];
                            span[3] = HexMap[(x >> 8) & 0xF];
                            span[4] = HexMap[(x >> 4) & 0xF];
                            span[5] = HexMap[x & 0xF];
                            writer.Advance(6);
                        }

                        break;
                    }
                }
            }
            WriteOutputByte((byte)'"');

        }

        public void WriteValue(bool value)
        {
            if (value == true)
            {
                WriteSpan(TrueValue);
            }
            else
            {
                WriteSpan(FalseValue);
            }
        }

        public void WriteNull()
        {
            WriteSpan(NullValue);
        }

        public void WriteValue(TLObject obj)
        {
            WriteValue(new TLObjectWithExtra() { TLObject = obj });
        }

        internal void WriteValue(TLObjectWithExtra value)
        {
            if (value.TLObject == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            var converter = TLObjectFactory.GetConverterForTLObject(value.TLObject);
            converter.TdJsonWriteUnclosedObject(this, value.TLObject);
            if (value.Extra.HasValue)
            {
                WriteSpan(StringPool.Slice(_extrapos, _extralen)); // ,"@extra":
                WriteInt64String(value.Extra.Value);
            }
            WriteEndObject();
        }

        public void WriteBoxedValue(object value)
        {
            if (value == null)
            {
                WriteNull();
                return;
            }
            switch (value)
            {
                case sbyte i:
                    WriteValue(i);
                    break;
                case short i:
                    WriteValue(i);
                    break;
                case int i:
                    WriteValue(i);
                    break;
                case long i:
                    WriteValue(i);
                    break;
                case byte i:
                    WriteValue(i);
                    break;
                case ushort i:
                    WriteValue(i);
                    break;
                case uint i:
                    WriteValue(i);
                    break;
                case ulong i:
                    WriteValue(i);
                    break;
                case string s:
                    WriteValue(s);
                    break;
                case double d:
                    WriteValue(d);
                    break;
                case float f:
                    WriteValue(f);
                    break;
                case TLObject o:
                    WriteValue(o);
                    break;
                default:
                    WriteValue(value.ToString());
                    break;
            }
        }

        public void WriteInt64String(long value)
        {
            WriteOutputByte((byte)'"');
            WriteValue(value);
            WriteOutputByte((byte)'"');
        }

        public void WriteEndObject()
        {
            WriteOutputByte((byte)'}');
        }

        private bool TryWriteEmptyArray(Array x)
        {
            if (x.Length != 0) return false;
            WriteSpan(EmptyArray);
            return true;

        }

        public void WriteBytesValue(byte[] value)
        {
            if (value == null || value.Length == 0)
            {
                WriteSpan(EmptyString);
                return;
            }

            var encodedLength = Base64.GetMaxEncodedToUtf8Length(value.Length);
            var dest = writer.GetSpan(encodedLength);
            var status = Base64.EncodeToUtf8(value, dest, out var consumed, out var written, true);
            if (status != OperationStatus.Done)
            {
                writer.Advance(0);
                throw new InvalidDataException();
            }
            writer.Advance(written);
        }

        public void WriteArray(int[] value)
        {
            if (TryWriteEmptyArray(value)) return;
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }

        public void WriteArray(long[] value)
        {
            if (TryWriteEmptyArray(value)) return;
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }

        public void WriteArray(string[] value)
        {
            if (TryWriteEmptyArray(value)) return;
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }

        public void WriteArray(byte[][] value)
        {
            if (TryWriteEmptyArray(value)) return;
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteBytesValue(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }

        public void WriteArray(TLObject[] value)
        {
            if (TryWriteEmptyArray(value)) return;
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }

        public void WriteArray(TLObject[][] value)
        {
            if (TryWriteEmptyArray(value)) return;
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteArray(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }

        internal void WriteInt64Array(long[] value)
        {
            if (TryWriteEmptyArray(value)) return;
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteInt64String(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }
    }
}
