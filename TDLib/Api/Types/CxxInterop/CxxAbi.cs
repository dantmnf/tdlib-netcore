using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TDLib.Api.Types.CxxInterop
{
    static class CxxAbi
    {
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        private static extern void td_bridge_object_destroy(IntPtr client);
        public static void FreeCxxTLObject(IntPtr obj)
        {
            td_bridge_object_destroy(obj);
        }
    }
}
