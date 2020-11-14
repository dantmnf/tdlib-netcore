using System;
using System.Collections.Generic;
using System.Text;
using TDLibCore.Api;

namespace TDLibCore
{
    public interface IExclusiveWorkerClientImpl : IDisposable
    {
        ITdClientLogging GlobalLogging { get; }
        TLObject Execute(Function func);
        void Send(Function func, long id);
        (long id, TLObject obj) Receive(double timeout);
    }
}
