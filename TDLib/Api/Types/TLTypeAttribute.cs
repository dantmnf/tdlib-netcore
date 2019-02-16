using System;
using System.Collections.Generic;
using System.Text;

namespace TDLib.Api.Types
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
