using System;
using TDLibCore.Api;

namespace TDLibCore.NativeClient
{
    internal abstract class BaseCxxBridge
    {
        public abstract IntPtr CreateCxxObject(TLObject obj);
        public abstract TLObject FetchCxxObject(IntPtr obj);
    }

    internal abstract class ObjectBridge<T> : BaseCxxBridge where T : TLObject { }
}
