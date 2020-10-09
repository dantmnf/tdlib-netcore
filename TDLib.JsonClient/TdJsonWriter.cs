using System;
using System.Buffers;
using System.IO;
using System.Text.Json;
using TDLib.Api;

namespace TDLib.JsonClient
{
    internal abstract unsafe partial class TdJsonWriter
    {
        // partial const int _extrapos;
        // partial const int _extralen;
        public abstract void WriteSpan(ReadOnlySpan<byte> span);
        protected abstract void WriteOutputByte(byte value);

        private void WriteASCIIStringBody(string str)
        {
            var len = str.Length;
            var pbytes = stackalloc byte[len];
            var bytes = new Span<byte>(pbytes, len);
            for (var i = 0; i < len; i++)
            {
                bytes[i] = unchecked((byte)str[i]);
            }
            WriteSpan(bytes);
        }

        public void WriteValue(long value)
        {
            var str = value.ToString();
            WriteASCIIStringBody(str);
        }

        public void WriteValue(ulong value)
        {
            var str = value.ToString();
            WriteASCIIStringBody(str);
        }

        public void WriteValue(double value)
        {
            var str = value.ToString();
            WriteASCIIStringBody(str);
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte Hex1(int value)
        {
            value &= 0xF;
            if (value <= 9)
            {
                return (byte)(0x30 + value);
            }
            return (byte)(0x37 + value);
        }

        public void WriteValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                var qqqq = 0x22222222u;
                WriteSpan(new ReadOnlySpan<byte>(&qqqq, 2));
                return;
            }
            WriteOutputByte((byte)'"');

            for (int i = 0; i < value.Length; i++)
            {
                var chr = value[i];
                if (chr >= 0x20 && chr <= 0x7E)
                {
                    if (chr == '"') WriteOutputByte(0x5C);
                    WriteOutputByte((byte)chr);
                    if (chr == 0x5C) WriteOutputByte(0x5C);
                }
                else if (chr == '\b')
                {
                    var xxbs = 0x0000625Cu;
                    WriteSpan(new ReadOnlySpan<byte>(&xxbs, 2));
                }
                else if (chr == '\f')
                {
                    var xxfs = 0x0000665Cu;
                    WriteSpan(new ReadOnlySpan<byte>(&xxfs, 2));
                }
                else if (chr == '\n')
                {
                    var xxns = 0x00006E5Cu;
                    WriteSpan(new ReadOnlySpan<byte>(&xxns, 2));
                }
                else if (chr == '\r')
                {
                    var xxrs = 0x0000725Cu;
                    WriteSpan(new ReadOnlySpan<byte>(&xxrs, 2));
                }
                else if (chr == '\t')
                {
                    var xxts = 0x0000745Cu;
                    WriteSpan(new ReadOnlySpan<byte>(&xxts, 2));
                }
                else // \uXXXX
                {
                    var seq = 0x000000000000755Cul;
                    var x = (int)chr;
                    seq |= (ulong)Hex1(x) << 40;
                    seq |= (ulong)Hex1(x >> 4) << 32;
                    seq |= (ulong)Hex1(x >> 8) << 24;
                    seq |= (ulong)Hex1(x >> 12) << 16;
                    WriteSpan(new ReadOnlySpan<byte>(&seq, 6));

                }
            }
            WriteOutputByte((byte)'"');

        }

        public void WriteValue(bool value)
        {
            if (value == true)
            {
                var eurt = 0x65757274u;
                WriteSpan(new ReadOnlySpan<byte>(&eurt, 4));
            }
            else
            {
                var xxxeslaf = 0x00000065736C6166ul;
                WriteSpan(new ReadOnlySpan<byte>(&xxxeslaf, 5));
            }
        }

        public void WriteNull()
        {
            var llun = 0x6C6C756Eu;
            WriteSpan(new ReadOnlySpan<byte>(&llun, 4));
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
            converter.TdJsonWriteItems(this, value.TLObject);
            if (value.Extra.HasValue)
            {
                WriteSpan(StringPool.Slice(_extrapos, _extralen)); // ,"@extra":
                WriteInt64String(value.Extra.Value);
            }
            WriteEndObject();
        }

        public void WriteValue(object value)
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

        public void WriteBytesValue(byte[] value)
        {
            if (value == null || value.Length == 0)
            {
                var qqqq = 0x22222222u;
                WriteSpan(new ReadOnlySpan<byte>(&qqqq, 2));
                return;
            }
            WriteValue(Convert.ToBase64String(value, Base64FormattingOptions.None));
        }

        public void WriteArray(int[] value)
        {
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
            WriteOutputByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteInt64String(value[i]);
                if (i != value.Length - 1) WriteOutputByte((byte)',');
            }
            WriteOutputByte((byte)']');
        }
    }

    internal class TdJsonBufferWriter : TdJsonWriter
    {
        private IBufferWriter<byte> writer;

        public TdJsonBufferWriter(IBufferWriter<byte> writer)
        {
            this.writer = writer;
        }
        public override void WriteSpan(ReadOnlySpan<byte> span)
        {
            var dest = writer.GetSpan(span.Length);
            span.CopyTo(dest);
            writer.Advance(span.Length);
        }

        protected override void WriteOutputByte(byte value)
        {
            var dest = writer.GetSpan(1);
            dest[0] = value;
            writer.Advance(1);
        }
    }
}
