using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static TDLib.Native;

namespace TDLib.Api.CxxInterop
{
    static class CxxAbi
    {
        public static void FreeCxxTLObject(IntPtr obj)
        {
            td_bridge_object_destroy(obj);
        }
    }
}
