namespace TDLibCore.Api
{
    public interface IMessageContentWithCaption
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
        public static FormattedText TryGetTextOrCaption(this MessageContent content)
        {
            switch (content)
            {
                case MessageText mt:
                    return mt.Text;
                case IMessageContentWithCaption cap:
                    return cap.Caption;
                default:
                    return null;
            }
            //PropertyInfo prop;
            //FormattedText ft = null;
            //if ((prop = content.GetType().GetProperty("text")) != null)
            //{
            //    ft = (FormattedText)prop.GetValue(content);
            //}
            //else if ((prop = content.GetType().GetProperty("caption")) != null)
            //{
            //    ft = (FormattedText)prop.GetValue(content);
            //}
            //return ft;
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
