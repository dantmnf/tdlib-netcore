using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Reflection;

namespace TDLib.Api.Types
{

    public partial class TLObject
    {
        internal virtual IntPtr TdCreateCxxObject()
        {
            throw new NotImplementedException();
        }

        internal virtual void TdFetchCxxObject(IntPtr ptr)
        {
            throw new NotImplementedException();
        }

    }
}
