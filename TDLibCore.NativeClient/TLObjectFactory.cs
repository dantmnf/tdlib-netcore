using System;
using System.Collections.Generic;
using System.Linq;
using TDLibCore.Api;
using static TDLibCore.NativeClient.Native;

namespace TDLibCore.NativeClient
{
    internal static class TLObjectFactory
    {
        private static Dictionary<int, Func<BaseCxxBridge>> _fetcher_map = new Dictionary<int, Func<BaseCxxBridge>>();
        private static Dictionary<Type, Func<BaseCxxBridge>> _creator_map = new Dictionary<Type, Func<BaseCxxBridge>>();
        static TLObjectFactory()
        {
            LoadTypeInfo();
        }

        static void LoadTypeInfo()
        {
            var asm = typeof(TLTypeIDAttribute).Assembly;
            var types = asm.GetTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeIDAttribute), false)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => (x.attrs.FirstOrDefault() as TLTypeIDAttribute, x.type)).ToArray();
            var count = 0;
            foreach (var (attr, bridge_type) in types)
            {
                count++;
                var ctor = (Func<BaseCxxBridge>)Delegate.CreateDelegate(typeof(Func<BaseCxxBridge>), bridge_type, "CreateInstance");
                _fetcher_map.Add(attr.Id, ctor);

                var bridge_generic_type = bridge_type.BaseType;
                while (bridge_generic_type != null)
                {
                    if (bridge_generic_type.GetGenericTypeDefinition() == typeof(ObjectBridge<>))
                        break;
                    bridge_generic_type = bridge_generic_type.BaseType;
                }
                if (bridge_generic_type == null)
                    throw new TypeLoadException($"bridge type {bridge_type.FullName} does not inherit from ObjectBridge<T>");
                var object_type = bridge_generic_type.GenericTypeArguments.FirstOrDefault();
                _creator_map.Add(object_type, ctor);
            }
            if (count != _fetcher_map.Count)
            {
                throw new TypeLoadException("collision found in type IDs");
            }
        }

        public static IntPtr CreateCxxObject(TLObject obj)
        {
            if (_creator_map.TryGetValue(obj.GetType(), out var ctor))
            {
                if (ctor != null)
                {
                    var bridge = ctor.Invoke();
                    return bridge.CreateCxxObject(obj);
                }
            }
            return IntPtr.Zero;
        }

        public static TLObject FetchCxxObject(IntPtr objptr)
        {
            var id = td_bridge_object_get_id(objptr);
            if (_fetcher_map.TryGetValue(id, out var ctor))
            {
                if (ctor != null)
                {
                    var bridge = ctor.Invoke();
                    return bridge.FetchCxxObject(objptr);
                }
            }
            throw new ArgumentException($"cannot fetch object from pointer 0x{objptr:x}, id = {id}");
        }
    }
}
