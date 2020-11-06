using System.Text.Json;
using TDLibCore.Api;

namespace TDLibCore.JsonClient
{
    abstract partial class BaseConverter
    {
        public virtual bool TdJsonReadItem(ref Utf8JsonReader reader, TLObject obj, uint keyhash) => false;

        /// <remarks>
        /// Doesn't write EndObject token '}'.
        /// </remarks>
        /// <param name="writer"></param>
        /// <param name="obj"></param>
        public abstract void TdJsonWriteUnclosedObject(Utf8JsonWriter writer, TLObject obj);

        public abstract TLObject CreateObjectInstance();
    }

    abstract partial class TLObjectConverter<T> : BaseConverter where T : TLObject { }
}
