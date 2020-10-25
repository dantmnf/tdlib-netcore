using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using TDLib.Api;

namespace TDLib.JsonClient.Utf8JsonExtension
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
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<string>();
                objs.Add(reader.GetString());
                while (reader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(reader.GetString());
                }
                return objs.ToArray();
            }
            return Array.Empty<string>();
        }

        public static byte[][] ReadBytesArray(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<byte[]>();
                objs.Add(reader.GetBytesFromBase64());
                while (reader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(reader.GetBytesFromBase64());
                }
                return objs.ToArray();
            }
            return Array.Empty<byte[]>();
        }

        public static int[] ReadInt32Array(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<int>();
                objs.Add(reader.GetInt32());
                while (reader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(reader.GetInt32());
                }
                return objs.ToArray();
            }
            return Array.Empty<int>();
        }

        public static long[] ReadInt53Array(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<long>();
                objs.Add(reader.GetInt64());
                while (reader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(reader.GetInt64());
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public static long[] ReadInt64Array(this ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<long>();
                objs.Add(long.Parse(reader.GetString()));
                while (reader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(long.Parse(reader.GetString()));
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public static T[] ReadObjectArray<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<T>();
                objs.Add(reader.ReadTLObject<T>());
                while (reader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(reader.ReadTLObject<T>());
                }
                return objs.ToArray();
            }
            return Array.Empty<T>();
        }

        public static T[][] ReadNestedObjectArray<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartArray);
            var type = reader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<T[]>();
                objs.Add(reader.ReadObjectArray<T>());
                while (reader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(reader.ReadObjectArray<T>());
                }
                return objs.ToArray();
            }
            return Array.Empty<T[]>();
        }
       

        internal static T ReadTLObject<T>(this ref Utf8JsonReader reader) where T : TLObject
        {
            var result = TLObjectFactory.ReadObject(ref reader);
            return (T)result;
        }

    }
}
