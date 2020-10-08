using System;
using System.IO;

namespace TDLib.JsonClient.UtilityExtension
{
    static class Extensions
    {
        public static ReadOnlySpan<byte> GetSpan(this MemoryStream ms)
        {
            if (ms.TryGetBuffer(out var seg))
            {
                return seg;
            }
            else
            {
                return ms.ToArray();
            }
        }
    }
}
