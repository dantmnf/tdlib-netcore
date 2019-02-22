using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace TDLib
{
    static class Native
    {
        public static unsafe int strlen(byte* str)
        {
            int result = 0;
            while (*str++ != 0) result++;
            return result;
        }
    }
}
