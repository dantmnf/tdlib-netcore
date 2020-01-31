using System;
using System.Collections.Generic;
using System.Text;
using TDLib.Api;

namespace TDLib.JsonClient
{
    abstract partial class BaseMarshal
    {
        // partial const int _extrapos;
        // partial const int _extralen;
        internal virtual bool TdJsonReadItem(ref TdJsonReader reader, ref TLObjectWithExtra obj, uint hash)
        {
            if (hash != 0x358751B7u) // @extra
                return false;
            try
            {
                obj.Extra = reader.ReadIntegerString();
                obj.HasExtra = true;
            }
            catch { }
            return true;

        }
        internal abstract void TdJsonWrite(TdJsonWriter writer, ref TLObjectWithExtra obj);

        internal void TdJsonWriteExtra(TdJsonWriter writer, ref TLObjectWithExtra obj)
        {
            if (obj.HasExtra)
            {
                writer.WriteSpan(StringPool.Slice(_extrapos, _extralen));
                writer.WriteInt64String(obj.Extra);
            }
        }
    }
}
