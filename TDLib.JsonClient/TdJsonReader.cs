using System;
using System.Buffers;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using TDLib.Api;

namespace TDLib.JsonClient
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

    internal unsafe ref partial struct TdJsonReader
    {
        private readonly byte* cstr;
        private int position;
        public int BytesConsumed => position;
        public TdJsonReader(byte* json_cstr)
        {
            cstr = json_cstr;
            position = 0;
        }

        private ReadOnlySpan<byte> Slice(int begin, int end)
        {
            return new ReadOnlySpan<byte>(cstr + begin, end - begin);
        }
        private void ConsumeWhitespace()
        {
            while (cstr[position] != 0)
            {

                switch (cstr[position])
                {
                    case 0x09:
                    case 0x0a:
                    case 0x0d:
                    case 0x20:
                        position++;
                        continue;
                    default:
                        return;
                }
            }
            throw new EndOfStreamException();
        }

        public JsonTokenType GetCurrentTokenType()
        {
            switch (cstr[position])
            {
                case 0:
                    throw new EndOfStreamException();

                case (byte)'{':
                    return JsonTokenType.StartObject;

                case (byte)'[':
                    return JsonTokenType.StartArray;

                case (byte)'"':
                    return JsonTokenType.String;

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
                    return JsonTokenType.Number;

                case (byte)'t':
                    return JsonTokenType.True;

                case (byte)'f':
                    return JsonTokenType.False;

                case (byte)'n':
                    return JsonTokenType.Null;

                default:
                    return JsonTokenType.None;
            }

        }

        static readonly byte[] trueBytes = new byte[] { 116, 114, 117, 101 };
        static readonly byte[] falseBytes = new byte[] { 102, 97, 108, 115, 101 };
        static readonly byte[] nullBytes = new byte[] { 110, 117, 108, 108 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void AssertRemainingLength(uint size = 1)
        {
            var p = position;
            do
            {
                if (cstr[p] == 0) throw new EndOfStreamException();
                p++;
                size--;
            } while (size != 0);
        }

        private object ReadNull()
        {
            position++; // first byte examined before
            for (var i = 1; i < 4; i++)
            {
                if (cstr[position] == 0) throw new EndOfStreamException();
                if (cstr[position] != nullBytes[i]) throw new TdJsonReaderException(position, "invalid value");
                position++;
            }
            return null;
        }

        private bool ReadFalse()
        {
            position++; // first byte examined before
            for (var i = 1; i < 5; i++)
            {
                if (cstr[position] == 0) throw new EndOfStreamException();
                if (cstr[position] != falseBytes[i]) throw new TdJsonReaderException(position, "invalid value");
                position++;
            }
            return false;
        }

        private bool ReadTrue()
        {
            position++; // first byte examined before
            for (var i = 1; i < 4; i++)
            {
                if (cstr[position] == 0) throw new EndOfStreamException();
                if (cstr[position] != trueBytes[i]) throw new TdJsonReaderException(position, "invalid value");
                position++;
            }
            return true;
        }

        public bool ReadBool()
        {
            AssertRemainingLength();
            if (cstr[position] == 't') return ReadTrue();
            else if (cstr[position] == 'f') return ReadFalse();
            else throw new TdJsonReaderException(position, "invalid value type");
        }

        private long ReadInteger()
        {
            AssertRemainingLength();
            if (cstr[position] != 0x2d && (cstr[position] < 0x30 || cstr[position] > 0x39))
                throw new TdJsonReaderException(position, "invalid value type");
            var negative = false;
            long result = 0;
            if (cstr[position] == 0x2d)
            {
                negative = true;
                position++;
                AssertRemainingLength();
            }
            if (cstr[position] == 0x30)
            {
                position++;
                return 0;
            }
            while (cstr[position] != 0 && cstr[position] >= 0x30 && cstr[position] <= 0x39)
            {
                result = checked(result * 10 + (cstr[position] - 0x30));
                position++;
            }
            return negative ? -result : result;
        }

        public long ReadInt64String()
        {
            AssertRemainingLength();
            if (cstr[position] != (byte)'"')
                throw new TdJsonReaderException(position, "invalid value type");
            position++;
            var result = ReadInteger();
            if (cstr[position] != (byte)'"')
                throw new TdJsonReaderException(position, "invalid value type");
            position++;
            return result;
        }

        public LongOrDouble ReadNumber()
        {
            var intpart = ReadInteger();
            var fracpart = new ReadOnlySpan<byte>();
            int? exp = null;
            if (cstr[position] == (byte)'.')
            {
                position++;
                var fracstart = position;
                while (cstr[position] != 0 && cstr[position] >= 0x30 && cstr[position] <= 0x39) position++;
                fracpart = Slice(fracstart, position);
            }
            if (cstr[position] == (byte)'e' || cstr[position] == (byte)'E')
            {
                position++;
                AssertRemainingLength();
                var negative = false;
                exp = 0;
                if (cstr[position] == (byte)'-')
                {
                    negative = true;
                    position++;
                    AssertRemainingLength();
                }
                else if (cstr[position] == (byte)'+')
                {
                    position++;
                    AssertRemainingLength();
                }
                while (cstr[position] != 0 && cstr[position] >= 0x30 && cstr[position] <= 0x39)
                {
                    var digit = cstr[position] - 0x30;
                    exp = exp * 10 + digit;
                }
                if (negative) exp = -exp;
            }
            if (fracpart.IsEmpty && !exp.HasValue)
            {
                return LongOrDouble.FromLong(intpart);
            }
            double result = intpart;
            if (!fracpart.IsEmpty)
            {
                for (int i = 0; i < fracpart.Length; i++)
                {
                    result += (fracpart[i] - 0x30) / Math.Pow(10, i + 1);
                }
            }
            if (exp.HasValue)
            {
                result *= Math.Pow(10, exp.Value);
            }
            return LongOrDouble.FromDouble(result);
        }

        public int ReadInt() => unchecked((int)ReadLong());

        public long ReadLong() => ReadNumber().GetLong();

        public double ReadDouble() => ReadNumber().GetDouble();

        private int ReadHex1()
        {
            AssertRemainingLength();
            var value = cstr[position];
            int result;
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
                throw new TdJsonReaderException(position, "hexadecimal digit out of range");
            }
            position++;
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

        private unsafe void StreamWriteUTF8Codepoint<T>(ref T ms, uint codepoint) where T : ISlimWriter
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
                throw new TdJsonReaderException(position, "Unicode codepoint out of range");
            }
        }

        private void ReadStringToStream<T>(ref T ms) where T : ISlimWriter // generics with type constraint is needed to pass struct reference without boxing
        {
            if (cstr[position] != (byte)'"')
                throw new TdJsonReaderException(position, "invalid value type");
            position++;
            ushort prevu16 = 0;
            var instr = true;
            var beginliteral = position;
            while (cstr[position] != 0 && instr)
            {
                switch (cstr[position])
                {
                    case (byte)'\\':
                        if (position - beginliteral > 0)
                        {
                            // write saved literal
                            ms.Write(Slice(beginliteral, position));
                        }
                        AssertRemainingLength(2);
                        position++;
                        switch (cstr[position])
                        {
                            case (byte)'"':
                            case (byte)'\\':
                            case (byte)'/':
                                ms.WriteByte(cstr[position]);
                                position++;
                                break;
                            case (byte)'b':
                                ms.WriteByte((byte)'\b');
                                position++;
                                break;
                            case (byte)'f':
                                ms.WriteByte((byte)'\f');
                                position++;
                                break;
                            case (byte)'n':
                                ms.WriteByte((byte)'\n');
                                position++;
                                break;
                            case (byte)'r':
                                ms.WriteByte((byte)'\r');
                                position++;
                                break;
                            case (byte)'t':
                                ms.WriteByte((byte)'\t');
                                position++;
                                break;
                            case (byte)'u':
                                position++;
                                var hex4 = ReadHex4();
                                if (hex4 >= 0xD800 && hex4 <= 0xDBFF)
                                {
                                    prevu16 = hex4;
                                }
                                else if (hex4 >= 0xDC00 && hex4 <= 0xDFFF)
                                {
                                    if (prevu16 == 0)
                                    {
                                        throw new TdJsonReaderException(position, "UTF-16 surrogate pair without leading one");
                                    }
                                    uint uni = unchecked(((uint)prevu16 << 10) + hex4 + (0x10000u - (0xD800u << 10) - 0xDC00u));
                                    StreamWriteUTF8Codepoint(ref ms, uni);
                                }
                                else
                                {
                                    StreamWriteUTF8Codepoint(ref ms, hex4);
                                }
                                break;
                            default:
                                throw new TdJsonReaderException(position, "invalid escape sequence");
                        }
                        beginliteral = position;
                        break;
                    case (byte)'"':
                        if (position - beginliteral > 0)
                        {
                            //var bytes = Span.Slice(beginliteral, Position - beginliteral).ToArray();
                            ms.Write(Slice(beginliteral, position));
                        }
                        beginliteral = position;
                        instr = false;
                        position++;
                        break;
                    default:
                        position++;
                        break;
                }
            }
            if (instr) throw new TdJsonReaderException(position, "incomplete input");
        }

        private ArrayPoolBufferWriter<byte> ReadStringAsBuffer()
        {
            var bufwriter = new ArrayPoolBufferWriter<byte>(512);
            var slimwriter = new BufferSlimWriter(bufwriter);
            ReadStringToStream(ref slimwriter);
            return bufwriter;
        }

        public string ReadString()
        {
            using var buffer = ReadStringAsBuffer();
            return Encoding.UTF8.GetString(buffer.WrittenSpan);
        }

        public byte[] ReadBase64String()
        {
            var start = position;
            using var buffer = ReadStringAsBuffer();
            var span = buffer.GetSpan();
            var result = Base64.DecodeFromUtf8InPlace(span, out var length);
            if (result != OperationStatus.Done)
            {
                throw new TdJsonReaderException(start, "invalid base64 string");
            }
            return span.Slice(0, length).ToArray();
        }

        internal uint ReadStringAsHash()
        {
            var s = new Crc32SlimWriter();
            ReadStringToStream(ref s);
            return s.Hash;
        }

        /// <summary>
        /// Begin to consume an array.
        /// </summary>
        /// <returns><see cref="JsonTokenType"/> of first array element, or <see cref="JsonTokenType.None"/> if array is empty.</returns>
        public JsonTokenType BeginReadArray()
        {
            AssertRemainingLength();
            if (GetCurrentTokenType() != JsonTokenType.StartArray)
                throw new TdJsonReaderException(position, "invalid value type");
            position++;
            ConsumeWhitespace();
            AssertRemainingLength();
            if (cstr[position] == (byte)']')
            {
                position++;
                return JsonTokenType.None;
            }
            return GetCurrentTokenType();
        }

        /// <summary>
        /// Consume array element separator or EndArray token ']'.
        /// </summary>
        /// <returns><see cref="JsonTokenType"/> of next array element, or <see cref="JsonTokenType.None"/> if no more elements and the entire array is consumed.</returns>
        public JsonTokenType MoveToNextArrayElement()
        {
            if (cstr[position] != 0)
            {
                ConsumeWhitespace();
                AssertRemainingLength();
                switch (cstr[position])
                {
                    case (byte)',':
                        position++;
                        ConsumeWhitespace();
                        return GetCurrentTokenType();
                    case (byte)']':
                        position++;
                        return JsonTokenType.None;
                    default:
                        throw new TdJsonReaderException(position, "invalid token in array");
                }
            }
            throw new TdJsonReaderException(position, "incomplete input");
        }

        public string[] ReadStringArray()
        {
            if (BeginReadArray() != JsonTokenType.None)
            {
                var objs = new List<string>();
                objs.Add(ReadString());
                while (MoveToNextArrayElement() != JsonTokenType.None)
                {
                    objs.Add(ReadString());
                }
                return objs.ToArray();
            }
            return Array.Empty<string>();
        }

        public byte[][] ReadBytesArray()
        {
            if (BeginReadArray() != JsonTokenType.None)
            {
                var objs = new List<byte[]>();
                objs.Add(ReadBase64String());
                while (MoveToNextArrayElement() != JsonTokenType.None)
                {
                    objs.Add(ReadBase64String());
                }
                return objs.ToArray();
            }
            return Array.Empty<byte[]>();
        }

        public int[] ReadInt32Array()
        {
            if (BeginReadArray() != JsonTokenType.None)
            {
                var objs = new List<int>();
                objs.Add(ReadInt());
                while (MoveToNextArrayElement() != JsonTokenType.None)
                {
                    objs.Add(ReadInt());
                }
                return objs.ToArray();
            }
            return Array.Empty<int>();
        }

        public long[] ReadInt53Array()
        {
            if (BeginReadArray() != JsonTokenType.None)
            {
                var objs = new List<long>();
                objs.Add(ReadLong());
                while (MoveToNextArrayElement() != JsonTokenType.None)
                {
                    objs.Add(ReadLong());
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public long[] ReadInt64Array()
        {
            if (BeginReadArray() != JsonTokenType.None)
            {
                var objs = new List<long>();
                objs.Add(ReadInt64String());
                while (MoveToNextArrayElement() != JsonTokenType.None)
                {
                    objs.Add(ReadInt64String());
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public T[] ReadObjectArray<T>() where T : TLObject
        {
            if (BeginReadArray() != JsonTokenType.None)
            {
                var objs = new List<T>();
                objs.Add(ReadTLObject<T>());
                while (MoveToNextArrayElement() != JsonTokenType.None)
                {
                    objs.Add(ReadTLObject<T>());
                }
                return objs.ToArray();
            }
            return Array.Empty<T>();
        }

        public T[][] ReadNestedObjectArray<T>() where T : TLObject
        {
            if (BeginReadArray() != JsonTokenType.None)
            {
                var objs = new List<T[]>();
                objs.Add(ReadObjectArray<T>());
                while (MoveToNextArrayElement() != JsonTokenType.None)
                {
                    objs.Add(ReadObjectArray<T>());
                }
                return objs.ToArray();
            }
            return Array.Empty<T[]>();
        }

        /// <summary>
        /// Begin to consume an object.
        /// </summary>
        /// <returns>true if object is not empty. Caller should use <see cref="ReadString"/> family to consume object member key.</returns>
        public bool BeginReadObject()
        {
            AssertRemainingLength();
            if (cstr[position] != (byte)'{')
                throw new TdJsonReaderException(position, "invalid value type");
            position++;
            ConsumeWhitespace();
            switch (cstr[position])
            {
                case (byte)'"':
                    return true;
                case (byte)'}':
                    position++;
                    return false;
                default:
                    throw new TdJsonReaderException(position, "invalid token in object");
            }
        }

        /// <summary>
        /// Called after member key is consumed.
        /// </summary>
        /// <returns><see cref="JsonTokenType"/> of object member value.</returns>
        public JsonTokenType MoveToObjectMemberValue()
        {
            ConsumeWhitespace();
            AssertRemainingLength();
            if (cstr[position] == (byte)':')
            {
                position++;
                ConsumeWhitespace();
                return GetCurrentTokenType();
            }
            throw new TdJsonReaderException(position, "invalid token in object");

        }

        /// <summary>
        /// Called after value of current member is consumed.
        /// </summary>
        /// <returns>true if next member availiable, false means the entire object is consumed.</returns>
        public bool MoveToNextObjectMember()
        {
            ConsumeWhitespace();
            AssertRemainingLength();
            switch (cstr[position])
            {
                case (byte)',':
                    position++;
                    ConsumeWhitespace();
                    if (cstr[position] == (byte)'"')
                        return true;
                    throw new TdJsonReaderException(position, "invalid token in object");
                case (byte)'}':
                    position++;
                    return false;
                default:
                    throw new TdJsonReaderException(position, "invalid token in object");
            }
        }
        internal bool ReadNextObjectKey(out uint key, bool firstkey = false)
        {
            key = 0;
            while (cstr[position] != 0)
            {
                ConsumeWhitespace();
                switch (cstr[position])
                {
                    case (byte)',' when !firstkey:
                        position++;
                        continue;
                    case (byte)'"':
                        key = ReadStringAsHash();
                        ConsumeWhitespace();
                        if (cstr[position] != (byte)':')
                            throw new TdJsonReaderException(position, "object missing key-value delimiter");
                        position++;
                        ConsumeWhitespace();
                        return true;
                    case (byte)'}':
                        position++;
                        return false;
                    default:
                        throw new TdJsonReaderException(position, "invalid token in object");
                }
            }
            throw new TdJsonReaderException(position, "incomplete input");
        }

        internal T ReadTLObject<T>() where T : TLObject
        {
            var result = TLObjectFactory.ReadObject(ref this);
            return (T)result;
        }

    }
}
