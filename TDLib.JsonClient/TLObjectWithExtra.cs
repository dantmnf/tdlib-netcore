using System;
using System.Collections.Generic;
using System.Text;
using TDLib.Api;

namespace TDLib.JsonClient
{
    struct TLObjectWithExtra
    {
        public TLObject TLObject { get; set; }
        public bool HasExtra { get; set; }
        public long Extra { get; set; }
    }
}
