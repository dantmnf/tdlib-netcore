using System;
using System.Collections.Generic;
using System.Text;
using TDLib.Api;

namespace TDLib.CxxClient
{
    internal abstract class BaseCxxBridge
    {
        public abstract IntPtr CreateCxxObject(TLObject obj);
        public abstract TLObject FetchCxxObject(IntPtr obj);
    }
}
