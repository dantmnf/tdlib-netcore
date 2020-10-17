using System.Text.Json;
using TDLib.Api;

namespace TDLib.JsonClient
{
    abstract partial class BaseConverter
    {
        internal virtual bool TdJsonReadItem(ref Utf8JsonReader reader, TLObject obj, string key) => false;

        /// <remarks>
        /// Doesn't write EndObject token '}'.
        /// </remarks>
        /// <param name="writer"></param>
        /// <param name="obj"></param>
        internal abstract void TdJsonWriteUnclosedObject(Utf8JsonWriter writer, TLObject obj);
    }

    abstract partial class TLObjectConverter<T> : BaseConverter where T : TLObject { }
}
