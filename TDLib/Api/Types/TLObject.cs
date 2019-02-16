using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace TDLib.Api.Types
{

    public partial class TLObject
    {
        [JsonProperty("@extra")]
        public object Extra { get; set; }

        internal virtual bool TdJsonReadItem(ref TdJsonReader parser, uint hash)
        {
            if (hash != 0x358751B7u)
                return false;
            this.Extra = parser.ReadValue();
            return true;
        }

    }
}
