using TDLib.Api;

namespace ConsoleApp1.Bot
{
    public abstract class PluginDispatcher
    {
        public abstract void Dispatch(Update u);
    }
}
