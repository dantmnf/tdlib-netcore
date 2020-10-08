using TDLib.Api;

namespace TDLib.JsonClient
{
    struct TLObjectWithExtra
    {
        public TLObject TLObject { get; set; }
        public long? Extra { get; set; }
    }
}
