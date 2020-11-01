using TDLibCore.Api;

namespace TDLibCore.JsonClient
{
    struct TLObjectWithExtra
    {
        public TLObject TLObject;
        public long? Extra;

        public TLObjectWithExtra(TLObject obj)
        {
            TLObject = obj;
            Extra = default;
        }

        public TLObjectWithExtra(TLObject obj, long extra)
        {
            TLObject = obj;
            Extra = extra;
        }
    }
}