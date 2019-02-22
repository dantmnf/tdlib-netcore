using TDLib.Api;

namespace TDLib
{
    internal interface ITdClientImpl
    {
        TLObject Execute(Function func);
        void Send(long id, Function func);
        (long id, TLObject obj) Receive(double timeout);
    }
}