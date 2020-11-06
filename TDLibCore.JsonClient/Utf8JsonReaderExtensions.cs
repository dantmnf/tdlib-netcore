using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using TDLibCore.Api;

namespace TDLibCore.JsonClient.Utf8JsonExtension
{

    internal static class Utf8JsonReaderExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static JsonTokenType ReadNextToken(this ref Utf8JsonReader reader)
        {
            if (reader.Read())
            {
                return reader.TokenType;
            }
            throw new JsonException("ReadNextToken");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReadAndConfirmNextToken(this ref Utf8JsonReader reader, JsonTokenType type)
        {
            if (reader.ReadNextToken() != type) throw new JsonException("ReadAndConfirmNextToken");
        }

        public static bool ReadBool(this ref Utf8JsonReader reader)
        {
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.True) return true;
            if (type == JsonTokenType.False) return false;
            throw new JsonException("ReadBool");
        }


        public static long ReadInt64String(this ref Utf8JsonReader reader)
        {
            var str = reader.ReadString();
            return long.Parse(str);
        }


        public static int ReadInt(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.Number);
            return reader.GetInt32();
        }

        public static long ReadLong(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.Number);
            return reader.GetInt64();
        }

        public static double ReadDouble(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.Number);
            return reader.GetDouble();
        }

        public static string ReadString(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.String);
            return reader.GetString();
        }

        public static byte[] ReadBase64String(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.String);
            return reader.GetBytesFromBase64();
        }

        public static string[] ReadStringArray(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.EndArray)
            {
                return Array.Empty<string>();
            }
            var objs = new List<string>();
            do
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.String:
                        objs.Add(reader.GetString());
                        break;
                    case JsonTokenType.EndArray:
                        goto stop;
                    default:
                        throw new JsonException();
                }
            } while (reader.Read());
        stop:
            return objs.ToArray();
        }

        public static byte[][] ReadBytesArray(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.EndArray)
            {
                return Array.Empty<byte[]>();
            }
            var objs = new List<byte[]>();
            do
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.String:
                        objs.Add(reader.GetBytesFromBase64());
                        break;
                    case JsonTokenType.EndArray:
                        goto stop;
                    default:
                        throw new JsonException();
                }
            } while (reader.Read());
        stop:
            return objs.ToArray();
        }

        public static int[] ReadInt32Array(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.EndArray)
            {
                return Array.Empty<int>();
            }
            var objs = new List<int>();
            do
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.Number:
                        objs.Add(reader.GetInt32());
                        break;
                    case JsonTokenType.EndArray:
                        goto stop;
                    default:
                        throw new JsonException();
                }
            } while (reader.Read());
        stop:
            return objs.ToArray();
        }

        public static long[] ReadInt53Array(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.EndArray)
            {
                return Array.Empty<long>();
            }
            var objs = new List<long>();
            do
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.Number:
                        objs.Add(reader.GetInt64());
                        break;
                    case JsonTokenType.EndArray:
                        goto stop;
                    default:
                        throw new JsonException();
                }
            } while (reader.Read());
        stop:
            return objs.ToArray();
        }

        public static long[] ReadInt64Array(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);

            var type = reader.ReadNextToken();
            if (type == JsonTokenType.EndArray)
            {
                return Array.Empty<long>();
            }
            var objs = new List<long>();
            do
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.String:
                        objs.Add(long.Parse(reader.GetString()));
                        break;
                    case JsonTokenType.EndArray:
                        goto stop;
                    default:
                        throw new JsonException();
                }
            } while (reader.Read());
        stop:
            return objs.ToArray();
        }

        public static T[] ReadObjectArray<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            return reader.GetObjectArray<T>();
        }

        public static T[] GetObjectArray<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.EndArray)
            {
                return Array.Empty<T>();
            }
            var objs = new List<T>();
            do
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        objs.Add(reader.GetTLObject<T>());
                        break;
                    case JsonTokenType.EndArray:
                        goto stop;
                    default:
                        throw new JsonException();
                }
            } while (reader.Read());
        stop:
            return objs.ToArray();
        }

        public static T[][] ReadNestedObjectArray<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.EndArray)
            {
                return Array.Empty<T[]>();
            }
            var objs = new List<T[]>();
            do
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartArray:
                        objs.Add(reader.GetObjectArray<T>());
                        break;
                    case JsonTokenType.EndArray:
                        goto stop;
                    default:
                        throw new JsonException();
                }
            } while (reader.Read());
        stop:
            return objs.ToArray();
        }


        internal static T GetTLObject<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            var result = TLObjectFactory.GetTLObject(ref reader);
            return (T)result;
        }

        internal static T ReadTLObject<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            reader.Read();
            var result = TLObjectFactory.GetTLObject(ref reader);
            return (T)result;
        }

        internal static unsafe uint GetStringHash(this ref Utf8JsonReader reader)
        {
            var span = reader.ValueSpan;
            var len = span.Length;
            var hash = 2166136261u;
            fixed (byte* buf = span)
            {
                for (int i = 0; i < len; i++)
                {
                    var octet = buf[i];
                    if (/* unlikely */ octet == (byte)'\\') goto escaped;
                    hash ^= octet;
                    hash *= 16777619;
                }
            }
            return hash;
        escaped:
            var str = reader.GetString();
            var u8str = ArrayPool<byte>.Shared.Rent(len);
            var u8len = Encoding.UTF8.GetBytes(str, 0, str.Length, u8str, 0);
            hash = Crc32C.Update(0, u8str.AsSpan(0, u8len));
            ArrayPool<byte>.Shared.Return(u8str);

            return hash;
        }

        internal static unsafe ReadOnlySpan<byte> GetUTF8String(this ref Utf8JsonReader reader, out IMemoryOwner<byte> owner)
        {
            // FIXME: https://github.com/dotnet/runtime/issues/1563
            var escaped = reader.ValueSpan;
            if (escaped.IndexOf((byte)'\\') == -1)
            {
                owner = default;
                return escaped;
            }
            // unlikely
            var str = reader.GetString();
            owner = MemoryPool<byte>.Shared.Rent(escaped.Length);
            var mem = owner.Memory;
            int unescaped_length;
            fixed (char* chars = str)
            fixed (byte* buf = mem.Span)
                unescaped_length = Encoding.UTF8.GetBytes(chars, str.Length, buf, escaped.Length);
            return mem.Slice(0, unescaped_length).Span;
        }
    }
}
