using System;
using System.Collections.Generic;
using System.Text;

namespace TDLib.Api.Types
{
    public abstract class Function : TLObject { }
    public abstract class Function<T> : Function where T : TLObject { }
}
