using System;

namespace TDLib.JsonClient
{
    //public class TLTypeAttribute : Attribute
    //{
    //    public TLTypeAttribute(string name)
    //    {
    //        TLType = name;
    //    }
    //    public string TLType { get; set; }
    //}

    public class TLTypeHashAttribute : Attribute
    {
        public TLTypeHashAttribute(uint hash)
        {
            Hash = hash;
        }
        public uint Hash { get; set; }
    }
}
