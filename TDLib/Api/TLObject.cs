using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Reflection;

namespace TDLib.Api
{
    public abstract class TLObject
    {
        internal abstract IntPtr TdCreateCxxObject();
        internal abstract void TdFetchCxxObject(IntPtr ptr);
    }
}
