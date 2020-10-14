using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using TDLib.Api;
using TDLib.JsonClient.Utf8JsonExtension;

namespace TDLib.JsonClient
{
    internal static partial class TLObjectFactory
    {
        // partial const uint @type_hash;
        // partial const uint @extra_hash;
        private static Dictionary<string, (Func<BaseConverter> mar, Func<TLObject> obj)> _typehash_map = new Dictionary<string, (Func<BaseConverter>, Func<TLObject>)>();
        private static Dictionary<Type, Func<BaseConverter>> _rtti_map = new Dictionary<Type, Func<BaseConverter>>();

        static TLObjectFactory()
        {
            // TODO: avoid reflection?
            var asm = typeof(BaseConverter).Assembly;
            var types = asm.GetTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeAttribute), true)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => (attr: x.attrs.FirstOrDefault() as TLTypeAttribute, type: x.type));
            var count = 0;
            foreach (var (attr, converter_type) in types)
            {
                count++;
                var converter_factory = (Func<BaseConverter>)Delegate.CreateDelegate(typeof(Func<BaseConverter>), converter_type, "CreateConverterInstance");
                var object_factory = (Func<TLObject>)Delegate.CreateDelegate(typeof(Func<TLObject>), converter_type, "CreateObjectInstance");
                _typehash_map.Add(attr.TLType, (converter_factory, object_factory));
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
                _rtti_map.Add(object_type, converter_factory);
            }
            if (count != _typehash_map.Count)
            {
                throw new TypeLoadException("collision found in type hashes");
            }
        }

        public static (TLObject, BaseConverter) CreateTLObjectAndConverter(string type)
        {
            if (_typehash_map.TryGetValue(type, out var ctors))
            {
                return (ctors.obj(), ctors.mar());
            }
            throw new ArgumentException($"unknown type {type}");
        }

        public static BaseConverter GetConverterForTLObject(TLObject obj)
        {
            if (_rtti_map.TryGetValue(obj.GetType(), out var ctor))
            {
                return ctor();
            }
            throw new ArgumentException($"unknown type {obj.GetType()}");
        }


        private static (TLObject, BaseConverter) ConsumeObjectProlog(ref Utf8JsonReader reader)
        {
            reader.AssertNextToken(System.Text.Json.JsonTokenType.PropertyName);
            var typestr = reader.GetString();
            if (typestr != "@type")
                throw new JsonException("object without @type");
            var token = reader.ReadNextToken();
            if (token != System.Text.Json.JsonTokenType.String)
                throw new JsonException("object without @type");
            var type = reader.GetString();

            var (obj, converter) = CreateTLObjectAndConverter(type);
            if (obj == null)
                throw new JsonException(string.Format("cannot create object with type {0}", type));
            return (obj, converter);
        }


        public static TLObjectWithExtra ReadRootObject(ref Utf8JsonReader reader)
        {
            reader.AssertNextToken(JsonTokenType.StartObject);
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            var result = new TLObjectWithExtra() { TLObject = obj };

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
                    throw new JsonException(string.Format("unrecognized key 0x{0:x8} in type {1}", key, obj.GetType().Name));
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
                    throw new JsonException(string.Format("unrecognized key 0x{0:x8} in type {1}", key, obj.GetType().Name));
                }
            }
            return obj;
        }
    }
}
