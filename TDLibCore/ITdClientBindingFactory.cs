using System;
using System.Collections.Generic;
using System.Text;

namespace TDLibCore
{
    public interface ITdClientBindingFactory
    {
        ITdClientBinding CreateInstance();
        ITdClientLogging GlobalLogging { get; }
    }
}
