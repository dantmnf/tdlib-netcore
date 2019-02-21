using System;
using System.Collections.Generic;
using System.Text;

namespace TDLib.Api.Types
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
