using TDLibCore.Api;

namespace TDLibCore.JsonClient
{
    public struct TLObjectWithExtra
    {
        public TLObject TLObject;
        public long? Extra;

        public TLObjectWithExtra(TLObject obj)
        {
            TLObject = obj;
            Extra = null;
        }

        public TLObjectWithExtra(TLObject obj, long extra)
        {
            TLObject = obj;
            Extra = extra;
        }
    }
}
