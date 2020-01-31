using System;
using System.Collections.Generic;
using System.Text;

namespace TDLib.CxxClient
{
    class TLTypeIDAttribute : Attribute
    {
        public TLTypeIDAttribute(int id, Type targetType)
        {
            Id = id;
            TargetType = targetType;
        }
        public int Id { get; set; }
        public Type TargetType { get; set; }
    }
}
