using System;
using System.Collections.Generic;
using System.Text;
using TDLib.Api;

namespace TDLib.JsonClient
{
    abstract partial class BaseConverter
    {
        internal virtual bool TdJsonReadItem(ref TdJsonReader reader, TLObject obj, uint hash) => false;

        /// <summary>
        /// Doesn't write EndObject token '}'.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="obj"></param>
        internal abstract void TdJsonWriteItems(TdJsonWriter writer, TLObject obj);
    }

    abstract partial class TLObjectConverter<T> : BaseConverter where T : TLObject { }
}
