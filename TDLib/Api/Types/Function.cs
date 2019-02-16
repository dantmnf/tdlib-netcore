using System;
using System.Collections.Generic;
using System.Text;

namespace TDLib.Api.Types
{
    public class Function : TLObject { }
    public class Function<T> : Function where T : TLObject
    {
    }
}
