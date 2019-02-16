using System;
using System.Collections.Generic;
using System.Text;
using TDLib.Api.Types;

namespace ConsoleApp1.Bot
{
    public class UpdateTypeDispatcher : PluginDispatcher
    {
        private User bot;
        private Dictionary<Type, Action<Update>> handlers;
        public UpdateTypeDispatcher(User botUser)
        {
            bot = botUser;
            handlers = new Dictionary<Type, Action<Update>>();
        }

        public void Add(Type type, Action<Update> handler)
        {
            if (handlers.ContainsKey(type))
            {
                handlers[type] += handler;
            }
            else
            {
                handlers[type] = handler;
            }
        }

        public override void Dispatch(Update u)
        {
            if (handlers.TryGetValue(u.GetType(), out var handler))
            {
                handler(u);
            }
        }
    }
}
