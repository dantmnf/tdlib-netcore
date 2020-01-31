using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDLib.Api;

namespace TDLib.JsonClient
{
    internal static class TLObjectFactory
    {
        private static Dictionary<uint, (Func<BaseMarshal> mar, Func<TLObject> obj)> _typehash_map = new Dictionary<uint, (Func<BaseMarshal>, Func<TLObject>)>();
        private static Dictionary<Type, Func<BaseMarshal>> _rtti_map = new Dictionary<Type, Func<BaseMarshal>>();
        static TLObjectFactory()
        {
            // TODO: avoid reflection?
            var asm = typeof(BaseMarshal).Assembly;
            var types = asm.GetTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeHashAttribute), true)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => (attr: x.attrs.FirstOrDefault() as TLTypeHashAttribute, type: x.type));
            var count = 0;
            foreach (var (attr, type) in types)
            {
                count++;
                var marctor = (Func<BaseMarshal>)Delegate.CreateDelegate(typeof(Func<BaseMarshal>), type, "CreateMarshalInstance");
                _typehash_map.Add(attr.Hash, (marctor, (Func<TLObject>)Delegate.CreateDelegate(typeof(Func<TLObject>), type, "CreateObjectInstance")));
                _rtti_map.Add(attr.TargetType, marctor);
            }
            if (count != _typehash_map.Count)
            {
                throw new TypeLoadException("collision found in type hashes");
            }
        }

        public static (TLObject, BaseMarshal) CreateTLObjectAndMarshal(uint typehash)
        {
            if (_typehash_map.TryGetValue(typehash, out var ctors))
            {
                return (ctors.obj.Invoke(), ctors.mar.Invoke());
                
            }
            throw new ArgumentException($"unknown typehash {typehash}");
        }

        public static BaseMarshal GetMarshalForTLObject(TLObject obj)
        {
            if (_rtti_map.TryGetValue(obj.GetType(), out var ctor))
            {
                return ctor.Invoke();
            }
            throw new ArgumentException($"unknown type {obj.GetType().Name}");
        }
    }
}
