using System;
using static TDLibCore.NativeClient.Native;

namespace TDLibCore.NativeClient.CxxInterop
{
    static class CxxAbi
    {
        public static void FreeCxxTLObject(IntPtr obj)
        {
            td_bridge_object_destroy(obj);
        }
    }
}
