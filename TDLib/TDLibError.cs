using System;

namespace TDLib
{
    public class TDLibError : Exception
    {
        public Api.Error Error { get; }
        public TDLibError(Api.Error e) : base($"{e.Message} ({e.Code})")
        {
            Error = e;
        }
    }
}
