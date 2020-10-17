using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TDLib.JsonClient
{
    static class MultiTargetHelper
    {
#if HAVE_AggressiveOptimization
        public const MethodImplOptions MethodImplOptions_AggressiveOptimization = MethodImplOptions.AggressiveOptimization;
#else
        public const MethodImplOptions MethodImplOptions_AggressiveOptimization = 0;
#endif
    }
}
