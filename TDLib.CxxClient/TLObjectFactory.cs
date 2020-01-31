using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using TDLib.Api;
using static TDLib.CxxClient.Native;

namespace TDLib.CxxClient
{
    internal static partial class TLObjectFactory
    {
        private static Dictionary<int, Func<BaseCxxBridge>> _fetcher_map = new Dictionary<int, Func<BaseCxxBridge>>();
        private static Dictionary<Type, Func<BaseCxxBridge>> _creator_map = new Dictionary<Type, Func<BaseCxxBridge>>();
        static TLObjectFactory()
        {
            LoadTypeInfo();
        }

        static void LoadTypeInfo()
        {
            // TODO: avoid reflection?
            var asm = typeof(TLTypeIDAttribute).Assembly;
            var types = asm.GetTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeIDAttribute), false)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => (x.attrs.FirstOrDefault() as TLTypeIDAttribute, x.type)).ToArray();
            var count = 0;
            foreach (var (attr, type) in types)
            {
                count++;
                var ctor = (Func<BaseCxxBridge>)Delegate.CreateDelegate(typeof(Func<BaseCxxBridge>), type, "CreateInstance");
                _fetcher_map.Add(attr.Id, ctor);
                _creator_map.Add(attr.TargetType, ctor);
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
