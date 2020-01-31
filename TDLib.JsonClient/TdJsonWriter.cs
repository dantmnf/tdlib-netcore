using System;
using System.IO;
using System.Runtime.CompilerServices;
using TDLib.Api;

namespace TDLib.JsonClient
{
    public unsafe class TdJsonWriter
    {

        public Stream Stream { get; set; }

        public TdJsonWriter(Stream s)
        {
            Stream = s;
        }

        public void WriteSpan(ReadOnlySpan<byte> value)
        {
            Stream.Write(value);
        }

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
            Stream.WriteByte((byte)'"');

            for (int i = 0; i < value.Length; i++)
            {
                var chr = value[i];
                if (chr >= 0x20 && chr <= 0x7E)
                {
                    if (chr == '"') Stream.WriteByte(0x5C);
                    Stream.WriteByte((byte)chr);
                    if (chr == 0x5C) Stream.WriteByte(0x5C);
                }
                else if (chr == '\b')
                {
                    var xxbs = 0x0000625Cu;
                    Stream.Write(new ReadOnlySpan<byte>(&xxbs, 2));
                }
                else if (chr == '\f')
                {
                    var xxfs = 0x0000665Cu;
                    Stream.Write(new ReadOnlySpan<byte>(&xxfs, 2));
                }
                else if (chr == '\n')
                {
                    var xxns = 0x00006E5Cu;
                    Stream.Write(new ReadOnlySpan<byte>(&xxns, 2));
                }
                else if (chr == '\r')
                {
                    var xxrs = 0x0000725Cu;
                    Stream.Write(new ReadOnlySpan<byte>(&xxrs, 2));
                }
                else if (chr == '\t')
                {
                    var xxts = 0x0000745Cu;
                    Stream.Write(new ReadOnlySpan<byte>(&xxts, 2));
                }
                else // \uXXXX
                {
                    var seq = 0x000000000000755Cul;
                    var x = (int)chr;
                    seq |= (ulong)Hex1(x) << 40;
                    seq |= (ulong)Hex1(x >> 4) << 32;
                    seq |= (ulong)Hex1(x >> 8) << 24;
                    seq |= (ulong)Hex1(x >> 12) << 16;
                    Stream.Write(new ReadOnlySpan<byte>(&seq, 6));

                }
            }
            Stream.WriteByte((byte)'"');

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
                WriteNull();
                return;
            }
            var mar = TLObjectFactory.GetMarshalForTLObject(value.TLObject);
            mar.TdJsonWrite(this, ref value);
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
            Stream.WriteByte((byte)'"');
            WriteValue(value);
            Stream.WriteByte((byte)'"');
        }

        public void WriteEndObject()
        {
            Stream.WriteByte((byte)'}');
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
            Stream.WriteByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) Stream.WriteByte((byte)',');
            }
            Stream.WriteByte((byte)']');
        }

        public void WriteArray(long[] value)
        {
            Stream.WriteByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) Stream.WriteByte((byte)',');
            }
            Stream.WriteByte((byte)']');
        }

        public void WriteArray(string[] value)
        {
            Stream.WriteByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) Stream.WriteByte((byte)',');
            }
            Stream.WriteByte((byte)']');
        }

        public void WriteArray(byte[][] value)
        {
            Stream.WriteByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteBytesValue(value[i]);
                if (i != value.Length - 1) Stream.WriteByte((byte)',');
            }
            Stream.WriteByte((byte)']');
        }

        public void WriteArray(TLObject[] value)
        {
            Stream.WriteByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteValue(value[i]);
                if (i != value.Length - 1) Stream.WriteByte((byte)',');
            }
            Stream.WriteByte((byte)']');
        }

        public void WriteArray(TLObject[][] value)
        {
            Stream.WriteByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteArray(value[i]);
                if (i != value.Length - 1) Stream.WriteByte((byte)',');
            }
            Stream.WriteByte((byte)']');
        }

        internal void WriteInt64Array(long[] value)
        {
            Stream.WriteByte((byte)'[');
            for (int i = 0; i < value.Length; i++)
            {
                WriteInt64String(value[i]);
                if (i != value.Length - 1) Stream.WriteByte((byte)',');
            }
            Stream.WriteByte((byte)']');
        }
    }
}