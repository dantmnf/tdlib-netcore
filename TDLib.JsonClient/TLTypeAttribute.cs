using System;

namespace TDLib.JsonClient
{
    public class TLTypeAttribute : Attribute
    {
        public TLTypeAttribute(string name)
        {
            TLType = name;
        }
        public string TLType { get; set; }
    }
}
