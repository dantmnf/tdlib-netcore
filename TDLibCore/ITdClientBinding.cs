using System;
using System.Collections.Generic;
using System.Text;
using TDLibCore.Api;

namespace TDLibCore
{
    public interface ITdClientBinding : IDisposable
    {
        ITdClientLogging GlobalLogging { get; }
        TLObject Execute(Function func);
        (long id, TLObject obj) Receive(double timeout);
        void Send(Function func, long id);
    }
}
