using System;
using System.Collections.Generic;
using System.Linq;
using TDLib.Api;

namespace TDLib.JsonClient
{
    internal static partial class TLObjectFactory
    {
        // partial const uint @type_hash;
        // partial const uint @extra_hash;
        private static Dictionary<uint, (Func<BaseConverter> mar, Func<TLObject> obj)> _typehash_map = new Dictionary<uint, (Func<BaseConverter>, Func<TLObject>)>();
        private static Dictionary<Type, Func<BaseConverter>> _rtti_map = new Dictionary<Type, Func<BaseConverter>>();

        static TLObjectFactory()
        {
            // TODO: avoid reflection?
            var asm = typeof(BaseConverter).Assembly;
            var types = asm.GetTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeHashAttribute), true)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => (attr: x.attrs.FirstOrDefault() as TLTypeHashAttribute, type: x.type));
            var count = 0;
            foreach (var (attr, converter_type) in types)
            {
                count++;
                var converter_factory = (Func<BaseConverter>)Delegate.CreateDelegate(typeof(Func<BaseConverter>), converter_type, "CreateConverterInstance");
                var object_factory = (Func<TLObject>)Delegate.CreateDelegate(typeof(Func<TLObject>), converter_type, "CreateObjectInstance");
                _typehash_map.Add(attr.Hash, (converter_factory, object_factory));
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

        public static (TLObject, BaseConverter) CreateTLObjectAndConverter(uint typehash)
        {
            if (_typehash_map.TryGetValue(typehash, out var ctors))
            {
                return (ctors.obj(), ctors.mar());

            }
            throw new ArgumentException($"unknown typehash {typehash}");
        }

        public static BaseConverter GetConverterForTLObject(TLObject obj)
        {
            if (_rtti_map.TryGetValue(obj.GetType(), out var ctor))
            {
                return ctor();
            }
            throw new ArgumentException($"unknown type {obj.GetType().Name}");
        }

        private static (TLObject, BaseConverter) ConsumeObjectProlog(ref TdJsonReader reader)
        {
            if (!reader.BeginReadObject())
                throw new TdJsonReaderException(reader.BytesConsumed, "object without @type");
            var keystr = reader.ReadStringUTF8();
            var key = Crc32C.Calcuate(keystr);
            if (key != type_hash)
                throw new TdJsonReaderException(reader.BytesConsumed, "object without @type");
            var token = reader.MoveToObjectMemberValue();
            if (token != TdJsonTokenType.String)
                throw new TdJsonReaderException(reader.BytesConsumed, "object without @type");
            var typestr = reader.ReadStringUTF8();
            var typehash = Crc32C.Calcuate(typestr);

            var (obj, converter) = CreateTLObjectAndConverter(typehash);
            if (obj == null)
                throw new TdJsonReaderException(reader.BytesConsumed, string.Format("cannot create object with type hash 0x{0:x8}", typehash));
            return (obj, converter);
        }

        public static TLObjectWithExtra ReadRootObject(ref TdJsonReader reader)
        {
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            var result = new TLObjectWithExtra() { TLObject = obj };

            while (reader.MoveToNextObjectMember())
            {
                var keystr = reader.ReadStringUTF8();
                var key = Crc32C.Calcuate(keystr);
                reader.MoveToObjectMemberValue();
                if (key == extra_hash)
                {
                    result.Extra = reader.ReadInt64String();
                    continue;
                }
                if (!converter.TdJsonReadItem(ref reader, obj, key))
                {
                    throw new TdJsonReaderException(reader.BytesConsumed, string.Format("unrecognized key 0x{0:x8} in type {1}", key, obj.GetType().Name));
                }
            }
            return result;
        }

        public static TLObject ReadObject(ref TdJsonReader reader)
        {
            var (obj, converter) = ConsumeObjectProlog(ref reader);
            while (reader.MoveToNextObjectMember())
            {
                var keystr = reader.ReadStringUTF8();
                var key = Crc32C.Calcuate(keystr);
                reader.MoveToObjectMemberValue();
                if (!converter.TdJsonReadItem(ref reader, obj, key))
                {
                    throw new TdJsonReaderException(reader.BytesConsumed, string.Format("unrecognized key 0x{0:x8} in type {1}", key, obj.GetType().Name));
                }
            }
            return obj;
        }
    }
}
