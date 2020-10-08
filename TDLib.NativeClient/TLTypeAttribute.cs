using System;

namespace TDLib.NativeClient
{
    class TLTypeIDAttribute : Attribute
    {
        public TLTypeIDAttribute(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
