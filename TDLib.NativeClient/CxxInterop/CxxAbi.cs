using System;
using static TDLib.NativeClient.Native;

namespace TDLib.NativeClient.CxxInterop
{
    static class CxxAbi
    {
        public static void FreeCxxTLObject(IntPtr obj)
        {
            td_bridge_object_destroy(obj);
        }
    }
}
