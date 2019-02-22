using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using TDLib.Api;
using TDLib.Api.CxxInterop;

namespace TDLib
{
    class ClientImplCxx : ITdClientImpl, IDisposable
    {
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr td_bridge_client_create();
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        private static extern void td_bridge_client_destroy(IntPtr client);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        private static extern void td_bridge_client_send(IntPtr client, long id, IntPtr func);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr td_bridge_client_receive(IntPtr client, double timeout, out long id);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr td_bridge_client_execute(IntPtr client, long inid, IntPtr func, out long outid);

        private IntPtr ptr;

        public ClientImplCxx()
        {
            ptr = td_bridge_client_create();
        }

        private static TLObject FetchAndFreeObject(IntPtr objptr)
        {
            if (objptr == IntPtr.Zero) return null;
            var obj = TLObjectFactory.FetchCxxObject(objptr);
            CxxAbi.FreeCxxTLObject(objptr);
            return obj;
        }

        public TLObject Execute(Function func)
        {
            var objptr = td_bridge_client_execute(ptr, 114514, func.TdCreateCxxObject(), out var id);
            return FetchAndFreeObject(ptr);
        }

        public (long, TLObject) Receive(double timeout)
        {
            var objptr = td_bridge_client_receive(ptr, timeout, out var id);
            return (id, FetchAndFreeObject(objptr));
        }

        public void Send(long id, Function func)
        {
            td_bridge_client_send(ptr, id, func.TdCreateCxxObject());
        }

        #region IDisposable
        ~ClientImplCxx()
        {
            Dispose();
        }
        public void Dispose()
        {
            if (ptr != IntPtr.Zero)
                td_bridge_client_destroy(ptr);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
