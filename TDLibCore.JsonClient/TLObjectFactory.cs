using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using TDLibCore.Api;
using TDLibCore.JsonClient.Utf8JsonExtension;

namespace TDLibCore.JsonClient
{
    public static class TLObjectFactory
    {
        private static Dictionary<uint, BaseConverter> _typehash_map = new Dictionary<uint, BaseConverter>();
        private static Dictionary<Type, BaseConverter> _rtti_map = new Dictionary<Type, BaseConverter>();

        static TLObjectFactory()
        {
            var asm = typeof(BaseConverter).Assembly;
            var types = asm.GetTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeAttribute), true)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => (attr: x.attrs.FirstOrDefault() as TLTypeAttribute, x.type));
            var count = 0;
            foreach (var (attr, converter_type) in types)
            {
                count++;
                var converter_factory = (Func<BaseConverter>)Delegate.CreateDelegate(typeof(Func<BaseConverter>), converter_type, "CreateConverterInstance");
                var converter_generic_type = converter_type.BaseType;
                while (converter_generic_type != null)
                {
                    if (converter_generic_type.GetGenericTypeDefinition() == typeof(TLObjectConverter<>))
                        break;
                    converter_generic_type = converter_generic_type.BaseType;
                }
                if (converter_generic_type == null)
                    throw new TypeLoadException($"converter type {converter_type.FullName} does not inherit from Converter<T>");
                var object_type = converter_generic_type.GenericTypeArguments.FirstOrDefault();
                var converter = converter_factory();
                _typehash_map.Add(Crc32C.Update(0, Encoding.UTF8.GetBytes(attr.TLType)), converter);
                _rtti_map.Add(object_type, converter);
            }
            if (count != _typehash_map.Count)
            {
                throw new TypeLoadException("collision found in type hashes");
            }
        }

        private static BaseConverter GetConverterForType(uint typehash)
        {
            if (_typehash_map.TryGetValue(typehash, out var conv))
            {
                return conv;
            }
            throw new ArgumentException($"unknown type {typehash}");
        }

        internal static BaseConverter GetConverterForTLObject(TLObject obj)
        {
            if (_rtti_map.TryGetValue(obj.GetType(), out var conv))
            {
                return conv;
            }
            throw new ArgumentException($"unknown type {obj.GetType()}");
        }


        private static (TLObject, BaseConverter) ConsumeObjectProlog(ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.PropertyName);
            if (!reader.ValueTextEquals(new ReadOnlySpan<byte>(new byte[] { 64, 116, 121, 112, 101 })))  // @type
                throw new JsonException("object without @type");
            var token = reader.ReadNextToken();
            if (token != JsonTokenType.String)
                throw new JsonException("object without @type");
            var name = reader.GetUTF8String(out var owner);
            var hash = BaseConverter.GetHashCodeForPropertyName(name);

            var converter = GetConverterForType(hash);
            owner?.Dispose();
            var obj = converter.CreateObjectInstance();
            if (obj == null)
                throw new JsonException(string.Format("cannot create object with type {0}", Encoding.UTF8.GetString(name.ToArray())));
            return (obj, converter);
        }

        private static ReadOnlySpan<byte> @extra_bytes => new byte[] { 64, 101, 120, 116, 114, 97 };
        public static TLObjectWithExtra ReadRootObject(ReadOnlySpan<byte> json)
        {
            var reader = new Utf8JsonReader(json);
            reader.ReadAndConfirmNextToken(JsonTokenType.StartObject);
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            var result = new TLObjectWithExtra(obj);

            while (true)
            {
                switch (reader.ReadNextToken())
                {
                    case JsonTokenType.PropertyName:
                        var name = reader.GetUTF8String(out var unescaped_owner);
                        
                        if(name.SequenceEqual(new ReadOnlySpan<byte>(new byte[] { 64, 101, 120, 116, 114, 97 }))) // "@extra"
                        {
                            result.Extra = reader.ReadInt64String();
                            continue;
                        }
                        var keyspan = reader.ValueSpan;
                        if (!converter.TdJsonReadItem(ref reader, obj, name))
                        {
                            var keystr = Encoding.UTF8.GetString(name.ToArray());
                            throw new JsonException($"unrecognized key {keystr} in type {obj.GetType().Name}");
                        }
                        unescaped_owner?.Dispose();
                        continue;
                    case JsonTokenType.EndObject:
                        goto break_loop;
                    default:
                        throw new JsonException();
                }
            }
            break_loop:
            return result;
        }

        internal static TLObject GetTLObject(ref Utf8JsonReader reader)
        {
            var type = reader.TokenType;
            if (type == JsonTokenType.Null) return null;
            if (type != JsonTokenType.StartObject) throw new JsonException();
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            while (true)
            {
                switch (reader.ReadNextToken())
                {
                    case JsonTokenType.PropertyName:
                        var name = reader.GetUTF8String(out var unescaped_owner);
                        if (!converter.TdJsonReadItem(ref reader, obj, name))
                        {
                            var keystr = Encoding.UTF8.GetString(name.ToArray());
                            throw new JsonException($"unrecognized key {keystr} in type {obj.GetType().Name}");
                        }
                        unescaped_owner?.Dispose();
                        continue;
                    case JsonTokenType.EndObject:
                        goto break_loop;
                    default:
                        throw new JsonException();
                }
            }
        break_loop:
            return obj;
        }

        public static void DumpObject(IBufferWriter<byte> buffer, TLObject obj)
        {
            using var writer = new Utf8JsonWriter(buffer, new JsonWriterOptions { Indented = false });
            writer.WriteTLObjectValue(obj);
            writer.Flush();
            var span = buffer.GetSpan(1);
            span[0] = 0;
            buffer.Advance(1);
        }

        public static void DumpObject(IBufferWriter<byte> buffer, TLObjectWithExtra obj)
        {
            using var writer = new Utf8JsonWriter(buffer, new JsonWriterOptions { Indented = false });
            writer.WriteTLObjectValue(obj);
            writer.Flush();
            var span = buffer.GetSpan(1);
            span[0] = 0;
            buffer.Advance(1);
        }
    }
}
