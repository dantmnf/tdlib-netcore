using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TDLib.Api;

namespace ConsoleApp1.Bot
{
    public abstract class PluginDispatcher
    {
        public abstract void Dispatch(Update u);
    }
}
