using System;
using System.Collections.Generic;
using System.Text;

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
        public TLTypeHashAttribute(uint hash, Type targetType)
        {
            Hash = hash;
            TargetType = targetType;
        }
        public uint Hash { get; set; }
        public Type TargetType { get; set; }
    }
}
