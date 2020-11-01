using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using TDLib.Api;
using TDLib.JsonClient.Utf8JsonExtension;

namespace TDLib.JsonClient
{
    internal static class TLObjectFactory
    {
        private static Dictionary<string, BaseConverter> _typehash_map = new Dictionary<string, BaseConverter>();
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
                _typehash_map.Add(attr.TLType, converter);
                _rtti_map.Add(object_type, converter);
            }
            if (count != _typehash_map.Count)
            {
                throw new TypeLoadException("collision found in type hashes");
            }
        }

        public static BaseConverter GetConverterForType(string type)
        {
            if (_typehash_map.TryGetValue(type, out var conv))
            {
                return conv;
            }
            throw new ArgumentException($"unknown type {type}");
        }

        public static BaseConverter GetConverterForTLObject(TLObject obj)
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
            var typestr = reader.GetString();
            if (typestr != "@type")
                throw new JsonException("object without @type");
            var token = reader.ReadNextToken();
            if (token != JsonTokenType.String)
                throw new JsonException("object without @type");
            var type = reader.GetString();

            var converter = GetConverterForType(type);
            var obj = converter.CreateObjectInstance();
            if (obj == null)
                throw new JsonException(string.Format("cannot create object with type {0}", type));
            return (obj, converter);
        }


        public static TLObjectWithExtra ReadRootObject(ref Utf8JsonReader reader)
        {
            reader.ReadAndConfirmNextToken(JsonTokenType.StartObject);
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            var result = new TLObjectWithExtra(obj);

            while (reader.ReadNextToken() != JsonTokenType.PropertyName)
            {
                var key = reader.GetString();
                if (key == "@extra")
                {
                    result.Extra = reader.ReadInt64String();
                    continue;
                }
                if (!converter.TdJsonReadItem(ref reader, obj, key))
                {
                    throw new JsonException($"unrecognized key {key} in type {obj.GetType().Name}");
                }
            }
            return result;
        }

        public static TLObject ReadObject(ref Utf8JsonReader reader)
        {
            var type = reader.ReadNextToken();
            if (type == JsonTokenType.Null) return null;
            if (type != JsonTokenType.StartObject) throw new JsonException();
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            while (reader.ReadNextToken() != JsonTokenType.PropertyName)
            {
                var key = reader.GetString();
                if (!converter.TdJsonReadItem(ref reader, obj, key))
                {
                    throw new JsonException(string.Format("unrecognized key {0} in type {1}", key, obj.GetType().Name));
                }
            }
            return obj;
        }
    }
}
