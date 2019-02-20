using TDLib.Api.Types;

namespace TDLib
{
    internal interface ITdClientImpl
    {
        TLObject Execute(Function func);
        void Send(long id, Function func);
        (long, TLObject) Receive(double timeout);
    }
}