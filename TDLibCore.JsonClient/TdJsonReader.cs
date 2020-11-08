using System;
using System.Buffers;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using TDLibCore.Api;

namespace TDLibCore.JsonClient
{
    public class TdJsonReaderException : Exception
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

    public enum TdJsonTokenType : byte
    {
        None,
        StartObject,
        EndObject,
        StartArray,
        EndArray,
        PropertyName,
        Comment,
        String,
        Number,
        True,
        False,
        Null
    }
    internal unsafe ref struct TdJsonReader
    {
        private readonly ReadOnlySpan<byte> cstr;
        private int position;
        public int BytesConsumed => position;

        private ArrayPoolBufferWriter<byte> strbuffer;

        public TdJsonReader(ReadOnlySpan<byte> json_cstr)
        {
            cstr = json_cstr;
            position = 0;
            strbuffer = new ArrayPoolBufferWriter<byte>(4096);
        }

        public void Dispose()
        {
            strbuffer.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ReadOnlySpan<byte> Slice(int begin, int end) => cstr.Slice(begin, end - begin + 1);

        private void ConsumeWhitespace()
        {
            while (position < cstr.Length)
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

        public TdJsonTokenType GetCurrentTokenType()
        {
            return (cstr[position]) switch
            {
                (byte)'{' => TdJsonTokenType.StartObject,
                (byte)'[' => TdJsonTokenType.StartArray,
                (byte)'"' => TdJsonTokenType.String,
                (byte)'-' or 0x30 or 0x31 or 0x32 or 0x33 or 0x34 or 0x35 or 0x36 or 0x37 or 0x38 or 0x39 => TdJsonTokenType.Number,
                (byte)'t' => TdJsonTokenType.True,
                (byte)'f' => TdJsonTokenType.False,
                (byte)'n' => TdJsonTokenType.Null,
                _ => throw new TdJsonReaderException(position, "invalid token")
            };
        }

        static ReadOnlySpan<byte> trueBytes => new byte[] { 116, 114, 117, 101 };
        static ReadOnlySpan<byte> falseBytes => new byte[] { 102, 97, 108, 115, 101 };
        static ReadOnlySpan<byte> nullBytes => new byte[] { 110, 117, 108, 108 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void AssertRemainingLength(uint size = 1)
        {
            if (position + size > cstr.Length) throw new EndOfStreamException();
        }

        private object ConfirmNull()
        {
            AssertRemainingLength(4);
            if (!cstr.Slice(position, 4).SequenceEqual(nullBytes))
                throw new TdJsonReaderException(position, "invalid value"); ;
            position += 4;
            return null;
        }

        private bool ConfirmFalse()
        {
            AssertRemainingLength(5);
            if (!cstr.Slice(position, 5).SequenceEqual(falseBytes))
                throw new TdJsonReaderException(position, "invalid value"); ;
            position += 5;
            return false;
        }

        private bool ConfirmTrue()
        {
            AssertRemainingLength(4);
            if (!cstr.Slice(position, 4).SequenceEqual(trueBytes))
                throw new TdJsonReaderException(position, "invalid value"); ;
            position += 4;
            return true;
        }

        public bool ReadBool()
        {
            AssertRemainingLength();
            if (cstr[position] == 't') return ConfirmTrue();
            else if (cstr[position] == 'f') return ConfirmFalse();
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

        private unsafe void WriteUTF8Codepoint(IBufferWriter<byte> writer, uint codepoint)
        {
            if (codepoint <= 0x7F)
            {
                writer.WriteByte((byte)codepoint);
                return;
            }

            var buf = writer.GetSpan(4);
            if (buf.Length < 4) throw new Exception("make JIT happy");
            if (codepoint <= 0x7FF)
            {
                buf[0] = (byte)((codepoint >> 6) | 0xC0);
                buf[1] = (byte)((codepoint & 0x3F) | 0x80);
                writer.Advance(2);
            }
            else if (codepoint < 0xD800 || (codepoint > 0xDFFF && codepoint <= 0xFFFF))
            {
                buf[0] = (byte)((codepoint >> 12) | 0xE0);
                buf[1] = (byte)((codepoint >> 6) & 0x3F | 0x80);
                buf[2] = (byte)((codepoint & 0x3F) | 0x80);
                writer.Advance(3);
            }
            else if (codepoint <= 0x10FFFF)
            {
                buf[0] = (byte)((codepoint >> 18) | 0xF0);
                buf[1] = (byte)((codepoint >> 12) & 0x3F | 0x80);
                buf[2] = (byte)((codepoint >> 6) & 0x3F | 0x80);
                buf[3] = (byte)((codepoint & 0x3F) | 0x80);
                writer.Advance(4);
            }
            else
            {
                throw new TdJsonReaderException(position, "Unicode codepoint out of range");
            }
        }

        internal static int FindNonStringLiteral(ReadOnlySpan<byte> input)
        {
            var len = 0;
            while (input.Length >= sizeof(ulong))
            {
                var qword = Unsafe.ReadUnaligned<ulong>(ref MemoryMarshal.GetReference(input));
                var result = BitHack.HasLess(qword, 32);
                result |= BitHack.HasValue(qword, (byte)'"');
                result |= BitHack.HasValue(qword, (byte)'\\');
                if (result != 0)
                {
                    return len + BitHack.GetNonZeroOctetIndex(result);
                }
                len += sizeof(ulong);
                input = input.Slice(sizeof(ulong));
            }
            if (input.Length >= 4)
            {
                var dword = Unsafe.ReadUnaligned<uint>(ref MemoryMarshal.GetReference(input));
                var result = BitHack.HasLess(dword, 32);
                result |= BitHack.HasValue(dword, (byte)'"');
                result |= BitHack.HasValue(dword, (byte)'\\');
                if (result != 0)
                {
                    return len + BitHack.GetNonZeroOctetIndex(result);
                }
                len += sizeof(uint);
                input = input.Slice(sizeof(uint));
            }
            switch (input.Length)
            {
                case 3:
                    if (input[2] is < 32 or (byte)'"' or (byte)'\\') return len + 2;
                    goto case 2;
                case 2:
                    if (input[1] is < 32 or (byte)'"' or (byte)'\\') return len + 1;
                    goto case 1;
                case 1:
                    if (input[0] is < 32 or (byte)'"' or (byte)'\\') return len + 0;
                    goto default;
                default:
                    return -1;
            }
        }

        public ReadOnlySpan<byte> ReadStringUTF8()
        {
            if (cstr[position] != (byte)'"')
                throw new TdJsonReaderException(position, "invalid value type");
            position++;
            ushort prevu16 = 0;
            var instr = true;
            var beginliteral = position;
            ReadOnlySpan<byte> result = default;
            var escaped = false;
            while (instr)
            {
                var input = cstr.Slice(position);
                var litlen = FindNonStringLiteral(input);
                var literal = input.Slice(0, litlen);
                position += litlen;
                switch (input[litlen])
                {
                    case (byte)'"':
                        if (escaped)
                        {
                            strbuffer.Write(literal);
                            result = strbuffer.WrittenSpan;
                        }
                        else
                        {
                            result = literal;
                        }
                        position++;
                        instr = false;
                        break;
                    case (byte)'\\':
                        if (!escaped)
                        {
                            escaped = true;
                            strbuffer.Reset();
                        }
                        // write saved literal
                        strbuffer.Write(literal);
                        AssertRemainingLength(2);
                        position+=2;
                        switch (cstr[position-1])
                        {
                            case (byte)'"':
                            case (byte)'\\':
                            case (byte)'/':
                                strbuffer.WriteByte(cstr[position]);
                                break;
                            case (byte)'b':
                                strbuffer.WriteByte((byte)'\b');
                                break;
                            case (byte)'f':
                                strbuffer.WriteByte((byte)'\f');
                                break;
                            case (byte)'n':
                                strbuffer.WriteByte((byte)'\n');
                                break;
                            case (byte)'r':
                                strbuffer.WriteByte((byte)'\r');
                                break;
                            case (byte)'t':
                                strbuffer.WriteByte((byte)'\t');
                                break;
                            case (byte)'u':
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
                                    WriteUTF8Codepoint(strbuffer, uni);
                                }
                                else
                                {
                                    WriteUTF8Codepoint(strbuffer, hex4);
                                }
                                break;
                            default:
                                throw new TdJsonReaderException(position, "invalid escape sequence");
                        }
                        break;

                    default:
                        throw new TdJsonReaderException(position, "invalid octet in string literal");
                }
            }
            if (instr) throw new TdJsonReaderException(position, "incomplete input");
            return result;
        }

        public string ReadString()
        {
            var u8str = ReadStringUTF8();
            return Encoding.UTF8.GetString(u8str);
        }

        public Memory<byte> ReadBase64String()
        {
            var start = position;
            var u8str = ReadStringUTF8();
            var len = Base64.GetMaxDecodedFromUtf8Length(u8str.Length);
            var array = MultiTargetHelper.AllocArray(len);
            var result = Base64.DecodeFromUtf8(u8str, array, out var consumed, out var length);
            if (result != OperationStatus.Done)
            {
                throw new TdJsonReaderException(start, "invalid base64 string");
            }
            return array.AsMemory(0, length);
        }

        /// <summary>
        /// Begin to consume an array.
        /// </summary>
        /// <returns><see cref="TdJsonTokenType"/> of first array element, or <see cref="TdJsonTokenType.None"/> if array is empty.</returns>
        public TdJsonTokenType BeginReadArray()
        {
            AssertRemainingLength();
            if (GetCurrentTokenType() != TdJsonTokenType.StartArray)
                throw new TdJsonReaderException(position, "invalid value type");
            position++;
            ConsumeWhitespace();
            AssertRemainingLength();
            if (cstr[position] == (byte)']')
            {
                position++;
                return TdJsonTokenType.None;
            }
            return GetCurrentTokenType();
        }

        /// <summary>
        /// Consume array element separator or EndArray token ']'.
        /// </summary>
        /// <returns><see cref="TdJsonTokenType"/> of next array element, or <see cref="TdJsonTokenType.None"/> if no more elements and the entire array is consumed.</returns>
        public TdJsonTokenType MoveToNextArrayElement()
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
                        return TdJsonTokenType.None;
                    default:
                        throw new TdJsonReaderException(position, "invalid token in array");
                }
            }
            throw new TdJsonReaderException(position, "incomplete input");
        }

        public string[] ReadStringArray()
        {
            TdJsonTokenType type;
            if ((type = BeginReadArray()) != TdJsonTokenType.None)
            {
                if (type != TdJsonTokenType.String) throw new TdJsonReaderException(position, "invalid token type");
                var objs = new List<string>();
                objs.Add(ReadString());
                while ((type = MoveToNextArrayElement()) != TdJsonTokenType.None)
                {
                    if (type != TdJsonTokenType.String) throw new TdJsonReaderException(position, "invalid token type");
                    objs.Add(ReadString());
                }
                return objs.ToArray();
            }
            return Array.Empty<string>();
        }

        public Memory<byte>[] ReadBytesArray()
        {
            TdJsonTokenType type;
            if ((type = BeginReadArray()) != TdJsonTokenType.None)
            {
                if (type != TdJsonTokenType.String) throw new TdJsonReaderException(position, "invalid token type");
                var objs = new List<Memory<byte>>();
                objs.Add(ReadBase64String());
                while ((type = MoveToNextArrayElement()) != TdJsonTokenType.None)
                {
                    if (type != TdJsonTokenType.String) throw new TdJsonReaderException(position, "invalid token type");
                    objs.Add(ReadBase64String());
                }
                return objs.ToArray();
            }
            return Array.Empty<Memory<byte>>();
        }

        public int[] ReadInt32Array()
        {
            TdJsonTokenType type;
            if ((type = BeginReadArray()) != TdJsonTokenType.None)
            {
                if (type != TdJsonTokenType.Number) throw new TdJsonReaderException(position, "invalid token type");
                var objs = new List<int>();
                objs.Add(ReadInt());
                while ((type = MoveToNextArrayElement()) != TdJsonTokenType.None)
                {
                    if (type != TdJsonTokenType.Number) throw new TdJsonReaderException(position, "invalid token type");
                    objs.Add(ReadInt());
                }
                return objs.ToArray();
            }
            return Array.Empty<int>();
        }

        public long[] ReadInt53Array()
        {
            TdJsonTokenType type;
            if ((type = BeginReadArray()) != TdJsonTokenType.None)
            {
                if (type != TdJsonTokenType.Number) throw new TdJsonReaderException(position, "invalid token type");
                var objs = new List<long>();
                objs.Add(ReadLong());
                while ((type = MoveToNextArrayElement()) != TdJsonTokenType.None)
                {
                    if (type != TdJsonTokenType.Number) throw new TdJsonReaderException(position, "invalid token type");
                    objs.Add(ReadLong());
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public long[] ReadInt64Array()
        {
            TdJsonTokenType type;
            if ((type = BeginReadArray()) != TdJsonTokenType.None)
            {
                if (type != TdJsonTokenType.String) throw new TdJsonReaderException(position, "invalid token type");
                var objs = new List<long>();
                objs.Add(ReadInt64String());
                while ((type = MoveToNextArrayElement()) != TdJsonTokenType.None)
                {
                    if (type != TdJsonTokenType.String) throw new TdJsonReaderException(position, "invalid token type");
                    objs.Add(ReadInt64String());
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public T[] ReadObjectArray<T>() where T : TLObject
        {
            TdJsonTokenType type;
            if ((type = BeginReadArray()) != TdJsonTokenType.None)
            {
                if (type != TdJsonTokenType.StartObject) throw new TdJsonReaderException(position, "invalid token type");
                var objs = new List<T>();
                objs.Add(ReadTLObject<T>());
                while ((type = MoveToNextArrayElement()) != TdJsonTokenType.None)
                {
                    if (type != TdJsonTokenType.StartObject) throw new TdJsonReaderException(position, "invalid token type");
                    objs.Add(ReadTLObject<T>());
                }
                return objs.ToArray();
            }
            return Array.Empty<T>();
        }

        public T[][] ReadNestedObjectArray<T>() where T : TLObject
        {
            TdJsonTokenType type;
            if ((type = BeginReadArray()) != TdJsonTokenType.None)
            {
                if (type != TdJsonTokenType.StartArray) throw new TdJsonReaderException(position, "invalid token type");
                var objs = new List<T[]>();
                objs.Add(ReadObjectArray<T>());
                while ((type = MoveToNextArrayElement()) != TdJsonTokenType.None)
                {
                    if (type != TdJsonTokenType.StartArray) throw new TdJsonReaderException(position, "invalid token type");
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
        /// <returns><see cref="TdJsonTokenType"/> of object member value.</returns>
        public TdJsonTokenType MoveToObjectMemberValue()
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

        internal T ReadTLObject<T>() where T : TLObject
        {
            var result = TLObjectFactory.ReadObject(ref this);
            return (T)result;
        }

    }
}
