using System;
using System.IO;

namespace TDLib.JsonClient
{

    internal unsafe static partial class StringPool
    {
        private static byte* _poolptr;
        private static int _poollen;
        private static byte[] _poolarr;
        private static object _keepref;

        internal static ReadOnlySpan<byte> Slice(int pos, int len)
        {
            if (_poolarr != null)
            {
                return _poolarr.AsSpan().Slice(pos, len);
            }
            return new ReadOnlySpan<byte>(_poolptr, _poollen).Slice(pos, len);
        }

        static StringPool()
        {
            var stream = typeof(StringPool).Assembly.GetManifestResourceStream("TDLib.JsonClient.Generated.pool.dat");
            if (stream == null)
            {
                throw new TypeLoadException("embedded resource pool.dat not found");
            }
            if (stream is UnmanagedMemoryStream ums)
            {
                _keepref = ums;
                _poolarr = null;
                _poolptr = ums.PositionPointer;
                _poollen = (int)ums.Length;
            }
            else
            {
                _poollen = (int)stream.Length;
                _poolarr = new byte[stream.Length];
                stream.Read(_poolarr);
            }
        }
    }
}
