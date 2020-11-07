using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using TDLibCore.Api;

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
                _typehash_map.Add(Hash.ComputeHash(Encoding.UTF8.GetBytes(attr.TLType)), converter);
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

        private static ReadOnlySpan<byte> @extra_bytes => new byte[] { 64, 101, 120, 116, 114, 97 };

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


        private static (TLObject, BaseConverter) ConsumeObjectProlog(ref TdJsonReader reader)
        {
            if (!reader.BeginReadObject())
                throw new TdJsonReaderException(reader.BytesConsumed, "object without @type");
            var keystr = reader.ReadStringUTF8();
            if (!keystr.SequenceEqual(new ReadOnlySpan<byte>(new byte[] { 64, 116, 121, 112, 101 })))
                throw new TdJsonReaderException(reader.BytesConsumed, "object without @type");
            var token = reader.MoveToObjectMemberValue();
            if (token != TdJsonTokenType.String)
                throw new TdJsonReaderException(reader.BytesConsumed, "object without @type");
            var typestr = reader.ReadStringUTF8();
            var typehash = Hash.ComputeHash(typestr);

            var converter = GetConverterForType(typehash);
            var obj = converter.CreateObjectInstance();
            if (obj == null)
                throw new JsonException(string.Format("cannot create object with type {0}", Encoding.UTF8.GetString(typestr.ToArray())));
            return (obj, converter);

        }

        internal static TLObjectWithExtra ReadRootObject(ReadOnlySpan<byte> input)
        {
            var reader = new TdJsonReader(input);
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            var result = new TLObjectWithExtra() { TLObject = obj };
            var hasextra = false;
            while (reader.MoveToNextObjectMember())
            {
                var keystr = reader.ReadStringUTF8();
                reader.MoveToObjectMemberValue();
                if (!hasextra && keystr.SequenceEqual(@extra_bytes))
                {
                    result.Extra = reader.ReadInt64String();
                    hasextra = true;
                    continue;
                }
                if (!converter.TdJsonReadItem(ref reader, obj, keystr))
                {
                    throw new TdJsonReaderException(reader.BytesConsumed, string.Format("unrecognized key {0} in type {1}", Encoding.UTF8.GetString(keystr), obj.GetType()));
                }
            }
            return result;
        }

        internal static TLObject ReadObject(ref TdJsonReader reader)
        {
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            

            while (reader.MoveToNextObjectMember())
            {
                var keystr = reader.ReadStringUTF8();
                reader.MoveToObjectMemberValue();
                if (!converter.TdJsonReadItem(ref reader, obj, keystr))
                {
                    throw new TdJsonReaderException(reader.BytesConsumed, string.Format("unrecognized key {0} in type {1}", Encoding.UTF8.GetString(keystr), obj.GetType()));
                }
            }
            return obj;
        }
    }
}
