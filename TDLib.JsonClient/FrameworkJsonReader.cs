using System;
using System.Collections.Generic;
using System.Text.Json;
using TDLib.Api;

namespace TDLib.JsonClient.Utf8JsonExtension
{

    internal static class FrameworkJsonReader
    {

        public static JsonTokenType ReadNextToken(this ref Utf8JsonReader fwreader)
        {
            if (fwreader.Read())
            {
                return fwreader.TokenType;
            }
            throw new JsonException("ReadNextToken");
        }

        public static void AssertNextToken(this ref Utf8JsonReader fwreader, JsonTokenType type)
        {
            if (fwreader.ReadNextToken() != type) throw new JsonException("AssertNextToken");
        }

        public static bool ReadBool(this ref Utf8JsonReader fwreader)
        {
            var type = fwreader.ReadNextToken();
            if (type == JsonTokenType.True) return true;
            if (type == JsonTokenType.False) return false;
            throw new JsonException("ReadBool");
        }


        public static long ReadInt64String(this ref Utf8JsonReader fwreader)
        {
            var str = fwreader.ReadString();
            return long.Parse(str);
        }

  
        public static int ReadInt(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.Number);
            return fwreader.GetInt32();
        }

        public static long ReadLong(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.Number);
            return fwreader.GetInt64();
        }

        public static double ReadDouble(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.Number);
            return fwreader.GetDouble();
        }

        public static string ReadString(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.String);
            return fwreader.GetString();
        }

        public static byte[] ReadBase64String(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.String);
            return fwreader.GetBytesFromBase64();
        }

        internal static uint ReadStringAsHash(this ref Utf8JsonReader fwreader)
        {
            return 0;
        }

        public static string[] ReadStringArray(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.StartArray);
            var type = fwreader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<string>();
                objs.Add(fwreader.GetString());
                while (fwreader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(fwreader.GetString());
                }
                return objs.ToArray();
            }
            return Array.Empty<string>();
        }

        public static byte[][] ReadBytesArray(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.StartArray);
            var type = fwreader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<byte[]>();
                objs.Add(fwreader.GetBytesFromBase64());
                while (fwreader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(fwreader.GetBytesFromBase64());
                }
                return objs.ToArray();
            }
            return Array.Empty<byte[]>();
        }

        public static int[] ReadInt32Array(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.StartArray);
            var type = fwreader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<int>();
                objs.Add(fwreader.GetInt32());
                while (fwreader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(fwreader.GetInt32());
                }
                return objs.ToArray();
            }
            return Array.Empty<int>();
        }

        public static long[] ReadInt53Array(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.StartArray);
            var type = fwreader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<long>();
                objs.Add(fwreader.GetInt64());
                while (fwreader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(fwreader.GetInt64());
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public static long[] ReadInt64Array(this ref Utf8JsonReader fwreader)
        {
            fwreader.AssertNextToken(JsonTokenType.StartArray);
            var type = fwreader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<long>();
                objs.Add(long.Parse(fwreader.GetString()));
                while (fwreader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(long.Parse(fwreader.GetString()));
                }
                return objs.ToArray();
            }
            return Array.Empty<long>();
        }

        public static T[] ReadObjectArray<T>(this ref Utf8JsonReader fwreader) where T : TLObject
        {
            fwreader.AssertNextToken(JsonTokenType.StartArray);
            var type = fwreader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<T>();
                objs.Add(fwreader.ReadTLObject<T>());
                while (fwreader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(fwreader.ReadTLObject<T>());
                }
                return objs.ToArray();
            }
            return Array.Empty<T>();
        }

        public static T[][] ReadNestedObjectArray<T>(this ref Utf8JsonReader fwreader) where T : TLObject
        {
            fwreader.AssertNextToken(JsonTokenType.StartArray);
            var type = fwreader.ReadNextToken();
            if (type != JsonTokenType.EndArray)
            {
                var objs = new List<T[]>();
                objs.Add(fwreader.ReadObjectArray<T>());
                while (fwreader.ReadNextToken() != JsonTokenType.EndArray)
                {
                    objs.Add(fwreader.ReadObjectArray<T>());
                }
                return objs.ToArray();
            }
            return Array.Empty<T[]>();
        }
       

        internal static T ReadTLObject<T>(this ref Utf8JsonReader fwreader) where T : TLObject
        {
            var result = TLObjectFactory.ReadObject(ref fwreader);
            return (T)result;
        }

    }
}
