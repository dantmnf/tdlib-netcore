using System;
using System.Buffers;
using System.Buffers.Text;
using System.IO;
using System.Text.Json;
using TDLib.Api;

namespace TDLib.JsonClient
{
    static partial class TdJsonWriter
    {
        internal static readonly JsonEncodedText TypePropertyName = JsonEncodedText.Encode("@type");
        internal static readonly JsonEncodedText ExtraPropertyName = JsonEncodedText.Encode("@extra");

        public static void WriteTLObjectValue(this Utf8JsonWriter writer, TLObject obj)
        {
            writer.WriteTLObjectValue(new TLObjectWithExtra() { TLObject = obj });
        }

        internal static void WriteTLObjectValue(this Utf8JsonWriter writer, TLObjectWithExtra value)
        {
            if (value.TLObject == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            var converter = TLObjectFactory.GetConverterForTLObject(value.TLObject);
            converter.TdJsonWriteUnclosedObject(writer, value.TLObject);
            if (value.Extra.HasValue)
            {
                writer.WritePropertyName(ExtraPropertyName);
                writer.WriteInt64String(value.Extra.Value);
            }
            writer.WriteEndObject();
        }

        public static void WriteInt64String(this Utf8JsonWriter writer, long value)
        {
            var buf = ArrayPool<byte>.Shared.Rent(32);
            Utf8Formatter.TryFormat(value, buf, out var length);
            writer.WriteStringValue(buf.AsSpan(0, length));
            ArrayPool<byte>.Shared.Return(buf);
        }


        public static void WriteArray(this Utf8JsonWriter writer, int[] value)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                writer.WriteNumberValue(value[i]);
            }
            writer.WriteEndArray();
        }

        public static void WriteArray(this Utf8JsonWriter writer, long[] value)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                writer.WriteNumberValue(value[i]);
            }
            writer.WriteEndArray();
        }

        public static void WriteArray(this Utf8JsonWriter writer, string[] value)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                writer.WriteStringValue(value[i]);
            }
            writer.WriteEndArray();
        }

        public static void WriteArray(this Utf8JsonWriter writer, byte[][] value)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                writer.WriteBase64StringValue(value[i]);
            }
            writer.WriteEndArray();
        }

        public static void WriteArray(this Utf8JsonWriter writer, TLObject[] value)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                writer.WriteTLObjectValue(value[i]);
            }
            writer.WriteEndArray();
        }

        public static void WriteArray(this Utf8JsonWriter writer, TLObject[][] value)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                writer.WriteArray(value[i]);
            }
            writer.WriteEndArray();
        }

        internal static void WriteInt64Array(this Utf8JsonWriter writer, long[] value)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                writer.WriteInt64String(value[i]);
            }
            writer.WriteEndArray();
        }
    }
}
