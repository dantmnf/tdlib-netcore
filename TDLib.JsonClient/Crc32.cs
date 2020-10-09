using System;
using System.Buffers;
using System.Runtime.InteropServices;
using System.Security;

namespace TDLib.JsonClient
{
    [SuppressUnmanagedCodeSecurity]
    internal static unsafe class Crc32
    {
        private delegate uint zlib_crc32_t(uint crc, byte* buf, int len);

        [DllImport("zlib1.dll", EntryPoint = "crc32", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint zlib_crc32_windows(uint crc, byte* buf, int len);
        [DllImport("zlib.dll" /* buggy CMake product */, EntryPoint = "crc32", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint zlib_crc32_windows2(uint crc, byte* buf, int len);
        [DllImport("libz.so.1" /* LSB */, EntryPoint = "crc32", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint zlib_crc32_linux(uint crc, byte* buf, int len);
        [DllImport("libz.1.dylib" /* built-in */, EntryPoint = "crc32", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint zlib_crc32_darwin(uint crc, byte* buf, int len);

        private static readonly uint[] table;
        private const uint poly = 0xedb88320u;

        private static zlib_crc32_t zlib_crc32;


        static Crc32()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                zlib_crc32 = zlib_crc32_linux;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                zlib_crc32 = zlib_crc32_darwin;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                zlib_crc32 = CheckDllCall(zlib_crc32_windows, zlib_crc32_windows2);
            if (zlib_crc32 == null)
            {
                table = new uint[16 * 256];
                for (uint i = 0; i < 256; i++)
                {
                    uint res = i;
                    for (int t = 0; t < 16; t++)
                    {
                        for (int k = 0; k < 8; k++) res = (res & 1) == 1 ? poly ^ (res >> 1) : (res >> 1);
                        table[(t * 256) + i] = res;
                    }
                }
            }
        }

        private static zlib_crc32_t CheckDllCall(params zlib_crc32_t[] delgs)
        {
            foreach (var delg in delgs)
            {
                try
                {
                    delg.Invoke(0, null, 0);
                    return delg;
                }
                catch (DllNotFoundException) { }
            }
            return null;
        }

        public static uint Update(uint crc, ReadOnlySpan<byte> input)
        {
            if (zlib_crc32 != null)
            {
                fixed (byte* buf = input)
                    return zlib_crc32.Invoke(crc, buf, input.Length);
            }
            uint crcLocal = uint.MaxValue ^ crc;
            var length = input.Length;
            var offset = 0;

            while (length >= 16)
            {
                var a = table[(3 * 256) + input[offset + 12]]
                    ^ table[(2 * 256) + input[offset + 13]]
                    ^ table[(1 * 256) + input[offset + 14]]
                    ^ table[(0 * 256) + input[offset + 15]];

                var b = table[(7 * 256) + input[offset + 8]]
                    ^ table[(6 * 256) + input[offset + 9]]
                    ^ table[(5 * 256) + input[offset + 10]]
                    ^ table[(4 * 256) + input[offset + 11]];

                var c = table[(11 * 256) + input[offset + 4]]
                    ^ table[(10 * 256) + input[offset + 5]]
                    ^ table[(9 * 256) + input[offset + 6]]
                    ^ table[(8 * 256) + input[offset + 7]];

                var d = table[(15 * 256) + ((byte)crcLocal ^ input[offset])]
                    ^ table[(14 * 256) + ((byte)(crcLocal >> 8) ^ input[offset + 1])]
                    ^ table[(13 * 256) + ((byte)(crcLocal >> 16) ^ input[offset + 2])]
                    ^ table[(12 * 256) + ((crcLocal >> 24) ^ input[offset + 3])];

                crcLocal = d ^ c ^ b ^ a;
                offset += 16;
                length -= 16;
            }

            while (--length >= 0)
                crcLocal = table[(byte)(crcLocal ^ input[offset++])] ^ crcLocal >> 8;

            return crcLocal ^ uint.MaxValue;
        }
    }

    internal unsafe struct Crc32SlimWriter : ISlimWriter
    {
        public uint Hash;

        public static Crc32SlimWriter Create() => new Crc32SlimWriter();
        public void WriteByte(byte value)
        {
            Hash = Crc32.Update(Hash, new ReadOnlySpan<byte>(&value, 1));
        }
        public void Write(ReadOnlySpan<byte> buf)
        {
            Hash = Crc32.Update(Hash, buf);
        }
    }
}
