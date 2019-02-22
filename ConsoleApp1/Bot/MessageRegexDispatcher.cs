using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;
using TDLib.Api.Types;
using System.Reflection;

namespace ConsoleApp1.Bot
{
    public class MessageRegexDispatcher : PluginDispatcher
    {
        private User bot;
        private Dictionary<(string re, RegexOptions opts), Action<Message, MatchCollection>> registered;
        public MessageRegexDispatcher(User botUser)
        {
            bot = botUser;
            registered = new Dictionary<(string re, RegexOptions opts), Action<Message, MatchCollection>>();
        }

        public void Add(string regex, RegexOptions options, Action<Message, MatchCollection> handler)
        {
            var tup = (regex, options);
            if (registered.ContainsKey(tup))
            {
                registered[tup] += handler;
            }
            else
            {
                registered[tup] = handler;
            }
        }

        public override void Dispatch(Update u)
        {
            if (!(u is UpdateNewMessage unm)) return;
            var message = unm.Message;
            if (!message.Content.TryGetTextOrCaption(out var ft)) return;
            foreach(var ((regex, opt), handler) in registered)
            {
                var match = Regex.Matches(ft.Text, regex, opt);
                if(match.Count != 0)
                {
                    handler(message, match);
                }
            }
        }

    }
}
