using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TDLib.Api.Types
{

    interface IMessageContentWithCaption
    {
        FormattedText Caption { get; set; }
    }

    partial class MessageAnimation : IMessageContentWithCaption { }
    partial class MessageAudio : IMessageContentWithCaption { }
    partial class MessageDocument : IMessageContentWithCaption { }
    partial class MessagePhoto : IMessageContentWithCaption { }
    partial class MessageVideo : IMessageContentWithCaption { }
    partial class MessageVoiceNote : IMessageContentWithCaption { }


    public static class TLObjectExtensions
    {
        public static bool TryGetTextOrCaption(this MessageContent content, out FormattedText ft)
        {
            switch (content)
            {
                case MessageText mt:
                    ft = mt.Text;
                    return true;
                case IMessageContentWithCaption cap:
                    ft = cap.Caption;
                    return true;
                default:
                    break;
            }
            PropertyInfo prop;
            ft = null;
            if ((prop = content.GetType().GetProperty("text")) != null)
            {
                ft = (FormattedText)prop.GetValue(content);
            }
            else if ((prop = content.GetType().GetProperty("caption")) != null)
            {
                ft = (FormattedText)prop.GetValue(content);
            }
            return ft != null;
        }
    }

    public partial class FormattedText
    {
        public static implicit operator FormattedText(string s)
        {
            return new FormattedText(s);
        }

        public override string ToString()
        {
            return Text;
        }
    }

}
