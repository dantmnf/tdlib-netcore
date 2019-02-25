using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TDLib.Api;
using static TDLib.Native;

namespace TDLib
{
    internal static class TLObjectFactory
    {
        private static Dictionary<int, Type> _tl_ids;
        static TLObjectFactory()
        {
            LoadTypeIDs();
        }

        static void LoadTypeIDs()
        {
            // TODO: avoid reflection?
            _tl_ids = new Dictionary<int, Type>();
            var asm = typeof(TLObject).Assembly;
            var types = asm.GetExportedTypes()
                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeIDAttribute), false)))
                .Where(x => x.attrs.Length != 0)
                .Select(x => ((x.attrs.FirstOrDefault() as TLTypeIDAttribute).Id, x.type));
            var count = 0;
            foreach (var (id, type) in types)
            {
                count++;
                _tl_ids.Add(id, type);
            }
            if (count != _tl_ids.Count)
            {
                throw new TypeLoadException("collision found in type IDs");
            }
        }



        public static TLObject FetchCxxObject(IntPtr objptr)
        {
            var id = td_bridge_object_get_id(objptr);
            if (_tl_ids.TryGetValue(id, out var type))
            {
                var ctor = type.GetConstructor(Type.EmptyTypes);
                if (ctor != null)
                {
                    var obj = (TLObject)ctor.Invoke(null);
                    obj.TdFetchCxxObject(objptr);
                    return obj;
                }
            }
            throw new ArgumentException($"cannot fetch object from pointer 0x{objptr:x}, id = {id}");
        }
    }
}
