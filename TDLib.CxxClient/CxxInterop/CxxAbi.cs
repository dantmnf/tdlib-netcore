using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static TDLib.CxxClient.Native;

namespace TDLib.CxxClient.CxxInterop
{
    static class CxxAbi
    {
        public static void FreeCxxTLObject(IntPtr obj)
        {
            td_bridge_object_destroy(obj);
        }
    }
}
