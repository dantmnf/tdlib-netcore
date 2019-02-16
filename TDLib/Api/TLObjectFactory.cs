using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDLib.Api.Types;

namespace TDLib.Api
{
    internal static class TLObjectFactory
    {
        private static Dictionary<uint, Type> _tl_types;
        static TLObjectFactory()
        {
            // TODO: avoid reflection?
            _tl_types = new Dictionary<uint, Type>();
            var asm = typeof(TLObject).Assembly;
            var types = asm.GetExportedTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeHashAttribute), true)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => (name: (x.attrs.FirstOrDefault() as TLTypeHashAttribute).Hash, type: x.type));
            var count = 0;
            foreach (var (hash, type) in types)
            {
                count++;
                _tl_types.Add(hash, type);
            }
            if (count != _tl_types.Count)
            {
                throw new TypeLoadException("collision found in type hashes");
            }
        }

        public static TLObject CreateTLObject(uint typehash)
        {
            if (_tl_types.TryGetValue(typehash, out var type))
            {
                var ctor = type.GetConstructor(Type.EmptyTypes);
                if (ctor != null)
                {
                    var obj = ctor.Invoke(null);
                    return (TLObject)obj;
                }
            }
            return null;
        }
    }
}
