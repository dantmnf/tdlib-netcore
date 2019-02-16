using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TDLib.Api.Types
{
    public static class TLObjectExtensions
    {
        public static bool TryGetTextOrCaption(this MessageContent content, out FormattedText ft)
        {
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
        public FormattedText() { }
        public FormattedText(string text)
        {
            this.text = text;
        }

        public static implicit operator FormattedText(string s)
        {
            return new FormattedText(s);
        }

        public override string ToString()
        {
            return text;
        }
    }

}
