using System;

namespace TDLib.CxxClient
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
