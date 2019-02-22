using System;
using System.Collections.Generic;
using System.Text;

namespace TDLib
{
    public class TDLibError : ApplicationException
    {
        public Api.Error Error { get; }
        public TDLibError(Api.Error e) : base($"{e.Message} ({e.Code})")
        {
            Error = e;
        }
    }
}
