using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Buffers.Binary;
using TDLib.Api.Types;
using System.IO;
using System.Runtime.CompilerServices;

namespace TDLib.Api
{
    public class TdJsonReaderException : ApplicationException
    {
        public int Position { get; }
        public TdJsonReaderException() : base() { }
        public TdJsonReaderException(int pos, string message) : base(message)
        {
            Position = pos;
        }
        public TdJsonReaderException(int pos, string message, Exception inner) : base(message, inner)
        {
            Position = pos;
        }

    }

    public ref struct TdJsonReader
    {
        public ReadOnlySpan<byte> Span;
        public int Position;
        public TdJsonReader(ReadOnlySpan<byte> jsonspan)
        {
            Span = jsonspan;
            Position = 0;
        }

        public void SkipWhiteSpace()
        {
            while (Position < Span.Length)
            {
                switch (Span[Position])
                {
                    case 0x09:
                    case 0x0a:
                    case 0x0d:
                    case 0x20:
                        Position++;
                        continue;
                    default:
                        return;
                }
            }
        }

        public object ReadValue()
        {
            try
            {
                SkipWhiteSpace();
                while (Position < Span.Length)
                {
                    switch (Span[Position])
                    {
                        case (byte)'{':
                            return ReadTLObject();

                        case (byte)'[':
                            return ReadArray();

                        case (byte)'"':
                            return ReadStringAsUTF16String();

                        case (byte)'-':
                        case 0x30:
                        case 0x31:
                        case 0x32:
                        case 0x33:
                        case 0x34:
                        case 0x35:
                        case 0x36:
                        case 0x37:
                        case 0x38:
                        case 0x39:
                            return ReadNumber();

                        case (byte)'t':
                            return ReadTrue();

                        case (byte)'f':
                            return ReadFalse();

                        case (byte)'n':
                            return ReadNull();

                        default:
                            throw new TdJsonReaderException(Position, string.Format("unrecognized token in: 0x{0:x2}", Span[Position]));
                    }
                }
                throw new TdJsonReaderException(Position, "incomplete input");
            }
            catch (IndexOutOfRangeException e)
            {
                throw new TdJsonReaderException(Position, "IndexOutOfRangeException thrown, incomplete input?", e);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new TdJsonReaderException(Position, "ArgumentOutOfRangeException thrown, incomplete input?", e);
            }
            catch (Exception e)
            {
                throw new TdJsonReaderException(Position, "Unhandled exception in TdJsonReader", e);
            }
        }

        static readonly byte[] trueBytes = new byte[] { 116, 114, 117, 101 };
        static readonly byte[] falseBytes = new byte[] { 102, 97, 108, 115, 101 };
        static readonly byte[] nullBytes = new byte[] { 110, 117, 108, 108 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void AssertRemainingLength(int x = 1)
        {
            if(Span.Length - Position < x)
                throw new TdJsonReaderException(Position, "incomplete input");
        }

        private object ReadNull()
        {
            AssertRemainingLength(4);
            if (Span.Slice(Position, 4).SequenceEqual(nullBytes))
            {
                Position += 4;
                return null;
            }
            throw new TdJsonReaderException(Position, "invalid value");
        }

        private bool ReadFalse()
        {
            AssertRemainingLength(5);
            if (Span.Slice(Position, 5).SequenceEqual(falseBytes))
            {
                Position += 5;
                return false;
            }
            throw new TdJsonReaderException(Position, "invalid value");
        }

        private bool ReadTrue()
        {
            AssertRemainingLength(4);
            if (Span.Slice(Position, 4).SequenceEqual(trueBytes))
            {
                Position += 4;
                return true;
            }
            throw new TdJsonReaderException(Position, "invalid value");
        }

        internal bool ReadBool()
        {
            AssertRemainingLength();
            if (Span[Position] == 't') return ReadTrue();
            else if (Span[Position] == 'f') return ReadFalse();
            else throw new TdJsonReaderException(Position, "invalid value type");
        }

        internal long ReadInteger()
        {
            AssertRemainingLength();
            if (Span[Position] != 0x2d && (Span[Position] < 0x30 || Span[Position] > 0x39))
                throw new TdJsonReaderException(Position, "invalid value type");
            var negative = false;
            long result = 0;
            if (Span[Position] == 0x2d)
            {
                negative = true;
                Position++;
            }
            if (Span[Position] == 0x30)
            {
                Position++;
                return 0;
            }
            while (Position < Span.Length && Span[Position] >= 0x30 && Span[Position] <= 0x39)
            {
                result = checked(result * 10 + (Span[Position] - 0x30));
                Position++;
            }
            return negative ? -result : result;
        }

        internal long ReadIntegerString()
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'"')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            var result = ReadInteger();
            if (Span[Position] != (byte)'"')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            return result;
        }

        private void ReadNumberInternal(out long intpart, out ReadOnlySpan<byte> fracpart, out long exp)
        {
            intpart = ReadInteger();
            exp = 0;
            fracpart = new ReadOnlySpan<byte>();
            if (Position < Span.Length && Span[Position] == (byte)'.')
            {
                Position++;
                var fracstart = Position;
                while (Position < Span.Length && Span[Position] >= 0x30 && Span[Position] <= 0x39) Position++;
                fracpart = Span.Slice(fracstart, Position - fracstart);
            }
            if (Position < Span.Length && Span[Position] == (byte)'e' || Span[Position] == (byte)'E')
            {
                Position++;
                exp = ReadInteger();
            }
        }

        public object ReadNumber()
        {
            ReadNumberInternal(out var intpart, out var fracpart, out var exp);
            if (fracpart.IsEmpty && exp == 0)
            {
                return intpart;
            }
            return FormatDouble(intpart, fracpart, exp);
        }

        public int ReadInt()
        {
            return unchecked((int)ReadDouble());
        }

        public long ReadLong()
        {

            return unchecked((long)ReadDouble());
        }

        private double FormatDouble(long intpart, ReadOnlySpan<byte> fracpart, long exp)
        {
            double result = intpart;
            if (!fracpart.IsEmpty)
            {
                for (int i = 0; i < fracpart.Length; i++)
                {
                    result += (fracpart[i] - 0x30) / Math.Pow(10, i + 1);
                }
            }
            if (exp != 0)
            {
                result = result * Math.Pow(10, exp);
            }
            return result;
        }

        public double ReadDouble()
        {
            ReadNumberInternal(out var intpart, out var fracpart, out var exp);
            return FormatDouble(intpart, fracpart, exp);
        }

        private int ReadHex1()
        {
            AssertRemainingLength();
            var value = Span[Position];
            var result = 0;
            if (value >= 0x30 && value <= 0x39)
            {
                result = value - 0x30;
            }
            else if (value >= 0x41 && value <= 0x46)
            {
                result = value - 0x37;
            }
            else if (value >= 0x61 && value <= 0x66)
            {
                result = value - 0x57;
            }
            else
            {
                throw new TdJsonReaderException(Position, "hexadecimal digit out of range");
            }
            Position++;
            return result;
        }

        private ushort ReadHex4()
        {
            ushort result = 0;
            result |= (ushort)ReadHex1();
            result <<= 4;
            result |= (ushort)ReadHex1();
            result <<= 4;
            result |= (ushort)ReadHex1();
            result <<= 4;
            result |= (ushort)ReadHex1();
            return result;
        }

        private unsafe void StreamWriteUTF8Codepoint(Stream ms, uint codepoint)
        {
            if (codepoint <= 0x7F)
            {
                ms.WriteByte((byte)codepoint);
                return;
            }

            int x = 0;
            var buf = new Span<byte>(&x, 4);

            if (codepoint <= 0x7FF)
            {
                buf[0] = (byte)((codepoint >> 6) | 0xC0);
                buf[1] = (byte)((codepoint & 0x3F) | 0x80);
                ms.Write(buf.Slice(0, 2));
            }
            else if (codepoint < 0xD800 || (codepoint > 0xDFFF && codepoint <= 0xFFFF))
            {
                buf[0] = (byte)((codepoint >> 12) | 0xE0);
                buf[1] = (byte)((codepoint >> 6) & 0x3F | 0x80);
                buf[2] = (byte)((codepoint & 0x3F) | 0x80);
                ms.Write(buf.Slice(0, 3));
            }
            else if (codepoint <= 0x10FFFF)
            {
                buf[0] = (byte)((codepoint >> 18) | 0xF0);
                buf[1] = (byte)((codepoint >> 12) & 0x3F | 0x80);
                buf[2] = (byte)((codepoint >> 6) & 0x3F | 0x80);
                buf[3] = (byte)((codepoint & 0x3F) | 0x80);
                ms.Write(buf.Slice(0, 4));
            }
            else
            {
                throw new TdJsonReaderException(Position, "Unicode codepoint out of range");
            }
        }

        private void ReadStringToStream(Stream ms)
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'"')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            ushort prevu16 = 0;
            var instr = true;
            var beginliteral = Position;
            while (Position < Span.Length && instr)
            {
                switch (Span[Position])
                {
                    case (byte)'\\':
                        if (Position - beginliteral > 0)
                        {
                            // var bytes = Span.Slice(beginliteral, Position - beginliteral).ToArray();
                            ms.Write(Span.Slice(beginliteral, Position - beginliteral));
                        }
                        AssertRemainingLength(2);
                        Position++;
                        switch (Span[Position])
                        {
                            case (byte)'"':
                            case (byte)'\\':
                            case (byte)'/':
                                ms.WriteByte(Span[Position]);
                                Position++;
                                break;
                            case (byte)'b':
                                ms.WriteByte((byte)'\b');
                                Position++;
                                break;
                            case (byte)'f':
                                ms.WriteByte((byte)'\f');
                                Position++;
                                break;
                            case (byte)'n':
                                ms.WriteByte((byte)'\n');
                                Position++;
                                break;
                            case (byte)'r':
                                ms.WriteByte((byte)'\r');
                                Position++;
                                break;
                            case (byte)'t':
                                ms.WriteByte((byte)'\t');
                                Position++;
                                break;
                            case (byte)'u':
                                Position++;
                                var hex4 = ReadHex4();
                                if (hex4 >= 0xD800 && hex4 <= 0xDBFF)
                                {
                                    prevu16 = hex4;
                                }
                                else if (hex4 >= 0xDC00 && hex4 <= 0xDFFF)
                                {
                                    if (prevu16 == 0)
                                    {
                                        throw new TdJsonReaderException(Position, "UTF-16 surrogate pair without leading one");
                                    }
                                    uint uni = unchecked(((uint)prevu16 << 10) + hex4 + (0x10000u - (0xD800u << 10) - 0xDC00u));
                                    StreamWriteUTF8Codepoint(ms, uni);
                                }
                                else
                                {
                                    StreamWriteUTF8Codepoint(ms, hex4);
                                }
                                break;
                            default:
                                throw new TdJsonReaderException(Position, "invalid escape sequence");
                        }
                        beginliteral = Position;
                        break;
                    case (byte)'"':
                        if (Position - beginliteral > 0)
                        {
                            //var bytes = Span.Slice(beginliteral, Position - beginliteral).ToArray();
                            ms.Write(Span.Slice(beginliteral, Position - beginliteral));
                        }
                        beginliteral = Position;
                        instr = false;
                        Position++;
                        break;
                    default:
                        Position++;
                        break;
                }
            }
            if (instr) throw new TdJsonReaderException(Position, "incomplete input");
        }

        public ArraySegment<byte> ReadStringAsUTF8ByteArray()
        {
            var ms = new MemoryStream(24);
            ReadStringToStream(ms);
            var len = ms.Length;
            if (ms.TryGetBuffer(out var buffer))
            {
                return buffer;
            }
            else
            {
                return new ArraySegment<byte>(ms.ToArray());
            }
        }

        internal uint ReadStringAsHash()
        {
            var s = new Crc32Stream();
            ReadStringToStream(s);
            return s.Hash;
        }

        public string ReadStringAsUTF16StringAlt()
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'"')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            var sb = new StringBuilder(24, int.MaxValue);
            var instr = true;
            var beginliteral = Position;
            while (Position < Span.Length && instr)
            {
                switch (Span[Position])
                {
                    case (byte)'\\':
                        Position++;
                        AssertRemainingLength();
                        switch (Span[Position])
                        {
                            case (byte)'"':
                            case (byte)'\\':
                            case (byte)'/':
                                sb.Append((char)Span[Position]);
                                Position++;
                                break;
                            case (byte)'b':
                                sb.Append('\b');
                                Position++;
                                break;
                            case (byte)'f':
                                sb.Append('\f');
                                Position++;
                                break;
                            case (byte)'n':
                                sb.Append('\n');
                                Position++;
                                break;
                            case (byte)'r':
                                sb.Append('\r');
                                Position++;
                                break;
                            case (byte)'t':
                                sb.Append('\t');
                                Position++;
                                break;
                            case (byte)'u':
                                Position++;
                                var hex4 = ReadHex4();
                                sb.Append((char)hex4);
                                break;
                            default:
                                throw new TdJsonReaderException(Position, "invalid escape sequence");
                        }
                        beginliteral = Position;
                        break;
                    case (byte)'"':
                        beginliteral = Position;
                        instr = false;
                        Position++;
                        break;
                    default:
                        var cp = ReadUTF8CodePoint();
                        if (cp <= 0xFFFF)
                        {
                            sb.Append((char)cp);
                        }
                        else
                        {
                            unchecked
                            {
                                const uint LEAD_OFFSET = 0xD800 - (0x10000 >> 10);
                                var lead = LEAD_OFFSET + (cp >> 10);
                                var trail = 0xDC00 + (cp & 0x3FF);
                                sb.Append((char)lead);
                                sb.Append((char)trail);
                            }
                        }
                        break;
                }
            }
            if (instr) throw new TdJsonReaderException(Position, "incomplete input");
            return sb.ToString();
        }

        private int ReadUTF8CodePoint()
        {
            int result;
            if ((Span[Position] & 0x80) == 0)
            {
                result = Span[Position];
                Position++;
            }
            else if ((Span[Position] >> 5) == 0b110 && Span.Length - Position >= 2) // 2-byte UTF-8
            {
                result = (Span[Position] & 0b00011111) << 6;
                Position++;
                result |= (Span[Position] & 0b00111111);
                Position++;
            }
            else if ((Span[Position] >> 4) == 0b1110 && Span.Length - Position >= 3) // 3-byte UTF-8
            {
                result = (Span[Position] & 0b00001111) << 12;
                Position++;
                result |= (Span[Position] & 0b00111111) << 6;
                Position++;
                result |= (Span[Position] & 0b00111111);
                Position++;
            }
            else if ((Span[Position] >> 3) == 0b11110 && Span.Length - Position >= 4) // 4-byte UTF-8
            {
                result = (Span[Position] & 0b00000111) << 18;
                Position++;
                result |= (Span[Position] & 0b00111111) << 12;
                Position++;
                result |= (Span[Position] & 0b00111111) << 6;
                Position++;
                result |= (Span[Position] & 0b00111111);
                Position++;
            }
            else
            {
                throw new TdJsonReaderException(Position, "incomplete UTF-8 byte sequence");
            }
            return result;
        }

        public string ReadStringAsUTF16String()
        {
            // TODO: use StringBuilder?
            // NOTE: StringBuilder gives little performance benefit
            var u8str = ReadStringAsUTF8ByteArray();
            return Encoding.UTF8.GetString(u8str.Array, u8str.Offset, u8str.Count);
        }

        internal byte[] ReadBase64String()
        {
            // TODO: convert from UTF-8 span
            var str = ReadStringAsUTF16String();
            var result = Convert.FromBase64String(str);
            return result;
        }

        public object[] ReadArray()
        {
            return ReadArray<object>();
        }

        private static object CheckNestedArray<T>(object obj)
        {
            if (!typeof(T).IsSubclassOf(typeof(Array))) return obj;
            var elemtype = typeof(T).GetElementType(); // T: X[]
            var objarr = (object[])obj;
            var newarr = Array.CreateInstance(elemtype, objarr.Length);
            for (var i = 0; i < objarr.Length; i++)
            {
                var value = objarr[i];
                if (elemtype == typeof(byte[]))
                {
                    value = Convert.FromBase64String((string)value);
                }
                newarr.SetValue(value, i);
            }
            return newarr;
        }

        public T[] ReadArray<T>()
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'[')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            SkipWhiteSpace();
            AssertRemainingLength();
            if (Span[Position] == (byte)']')
            {
                Position++;
                return Array.Empty<T>();
            }
            var objs = new List<T>();
            objs.Add((T)CheckNestedArray<T>(ReadValue()));
            bool inarray = true;
            while (inarray && Position < Span.Length)
            {
                SkipWhiteSpace();
                AssertRemainingLength();
                switch (Span[Position])
                {
                    case (byte)',':
                        Position++;
                        objs.Add((T)CheckNestedArray<T>(ReadValue()));
                        break;
                    case (byte)']':
                        Position++;
                        inarray = false;
                        break;
                    default:
                        throw new TdJsonReaderException(Position, "invalid token in array");
                }
            }
            if (inarray) throw new TdJsonReaderException(Position, "incomplete input");
            return objs.ToArray();
        }

        public byte[][] ReadBytesArray()
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'[')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            SkipWhiteSpace();
            AssertRemainingLength();
            if (Span[Position] == (byte)']')
            {
                Position++;
                return Array.Empty<byte[]>();
            }
            var objs = new List<byte[]>();
            objs.Add(ReadBase64String());
            bool inarray = true;
            while (inarray && Position < Span.Length)
            {
                SkipWhiteSpace();
                AssertRemainingLength();
                switch (Span[Position])
                {
                    case (byte)',':
                        Position++;
                        objs.Add(ReadBase64String());
                        break;
                    case (byte)']':
                        Position++;
                        inarray = false;
                        break;
                    default:
                        throw new TdJsonReaderException(Position, "invalid token in array");
                }
            }
            if (inarray) throw new TdJsonReaderException(Position, "incomplete input");
            return objs.ToArray();
        }

        public T[][] ReadNestedArray<T>()
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'[')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            SkipWhiteSpace();
            AssertRemainingLength();
            if (Span[Position] == (byte)']')
            {
                Position++;
                return Array.Empty<T[]>();
            }
            var objs = new List<T[]>();
            objs.Add(ReadArray<T>());
            bool inarray = true;
            while (inarray && Position < Span.Length)
            {
                SkipWhiteSpace();
                switch (Span[Position])
                {
                    case (byte)',':
                        Position++;
                        objs.Add(ReadArray<T>());
                        break;
                    case (byte)']':
                        Position++;
                        inarray = false;
                        break;
                    default:
                        throw new TdJsonReaderException(Position, "invalid token in array");
                }
            }
            if (inarray) throw new TdJsonReaderException(Position, "incomplete input");
            return objs.ToArray();
        }

        internal bool ReadNextObjectKey(out string key, bool firstkey = false)
        {
            key = null;
            while (Position < Span.Length)
            {
                SkipWhiteSpace();
                switch (Span[Position])
                {
                    case (byte)',' when !firstkey:
                        Position++;
                        continue;
                    case (byte)'"':
                        key = ReadStringAsUTF16String();
                        SkipWhiteSpace();
                        if (Span[Position] != (byte)':')
                            throw new TdJsonReaderException(Position, "object missing key-value delimiter");
                        Position++;
                        return true;
                    case (byte)'}':
                        Position++;
                        return false;
                    default:
                        throw new TdJsonReaderException(Position, "invalid token in object");
                }
            }
            throw new TdJsonReaderException(Position, "incomplete input");
        }

        internal bool ReadNextObjectKey(out uint key, bool firstkey = false)
        {
            key = 0;
            while (Position < Span.Length)
            {
                SkipWhiteSpace();
                switch (Span[Position])
                {
                    case (byte)',' when !firstkey:
                        Position++;
                        continue;
                    case (byte)'"':
                        key = ReadStringAsHash();
                        SkipWhiteSpace();
                        if (Span[Position] != (byte)':')
                            throw new TdJsonReaderException(Position, "object missing key-value delimiter");
                        Position++;
                        return true;
                    case (byte)'}':
                        Position++;
                        return false;
                    default:
                        throw new TdJsonReaderException(Position, "invalid token in object");
                }
            }
            throw new TdJsonReaderException(Position, "incomplete input");
        }

        public Dictionary<string, object> ReadObject()
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'{')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            SkipWhiteSpace();
            var objs = new Dictionary<string, object>();
            if (!ReadNextObjectKey(out string key, true))
                return objs;

            objs.Add(key, ReadValue());
            while (ReadNextObjectKey(out key))
            {
                objs.Add(key, ReadValue());
            }
            return objs;
        }

        internal TLObject ReadTLObject()
        {
            AssertRemainingLength();
            if (Span[Position] != (byte)'{')
                throw new TdJsonReaderException(Position, "invalid value type");
            Position++;
            SkipWhiteSpace();

            if (!(ReadNextObjectKey(out uint key, true) && key == 0x334B2761u))
                throw new TdJsonReaderException(Position, "object without @type");

            var typehash = ReadStringAsHash();
            var obj = TLObjectFactory.CreateTLObject(typehash);
            if (obj == null)
            {
                throw new TdJsonReaderException(Position, string.Format("cannot create object with type hash 0x{0:x8}", typehash));
            }
            while (ReadNextObjectKey(out key))
            {
                if (!obj.TdJsonReadItem(ref this, key))
                {
                    throw new TdJsonReaderException(Position, string.Format("unrecognized key 0x{0:x8} in type {1}", key, obj.GetType().Name));
                }
            }
            return obj;
        }


    }
}
