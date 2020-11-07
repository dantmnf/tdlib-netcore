using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TDLibCore.JsonClient
{
    static unsafe class BitHack
    {
        public static uint HasLess(uint x, byte n) => (((x) - ~0U / 255 * (n)) & ~(x) & ~0U / 255 * 128);
        public static ulong HasLess(ulong x, byte n) => (((x) - ~0UL / 255 * (n)) & ~(x) & ~0UL / 255 * 128);

        public static uint HasZero(uint v) => (((v) - 0x01010101U) & ~(v) & 0x80808080U);
        public static ulong HasZero(ulong v) => (((v) - 0x0101010101010101UL) & ~(v) & 0x8080808080808080UL);

        public static uint HasValue(uint x, byte n) => HasZero((x) ^ (~0U / 255 * (n)));
        public static ulong HasValue(ulong x, byte n) => HasZero((x) ^ (~0UL / 255 * (n)));

#if !NETSTANDARD2_0
        private static int GetNonZeroOctetIndexBE(uint x) => BitOperations.LeadingZeroCount(x) / 8;
        private static int GetNonZeroOctetIndexBE(ulong x) => BitOperations.LeadingZeroCount(x) / 8;

        private static int GetNonZeroOctetIndexLE(uint x) => BitOperations.TrailingZeroCount(x) / 8;
        private static int GetNonZeroOctetIndexLE(ulong x) => BitOperations.TrailingZeroCount(x) / 8;
#else
        private static int GetNonZeroOctetIndexBE(uint x)
        { 
            if ((x & 0xFF000000u) != 0) return 0;
            if ((x & 0x00FF0000u) != 0) return 1;
            if ((x & 0x0000FF00u) != 0) return 2;
            if ((x & 0x000000FFu) != 0) return 3;
            return 4;
        }
        private static int GetNonZeroOctetIndexBE(ulong x)
        {
            if ((x & 0xFF00000000000000UL) != 0) return 0;
            if ((x & 0x00FF000000000000UL) != 0) return 1;
            if ((x & 0x0000FF0000000000UL) != 0) return 2;
            if ((x & 0x000000FF00000000UL) != 0) return 3;
            if ((x & 0x00000000FF000000UL) != 0) return 4;
            if ((x & 0x0000000000FF0000UL) != 0) return 5;
            if ((x & 0x000000000000FF00UL) != 0) return 6;
            if ((x & 0x00000000000000FFUL) != 0) return 7;
            return 8;
        }

        private static int GetNonZeroOctetIndexLE(uint x)
        {
            if ((x & 0x000000FF) != 0) return 0;
            if ((x & 0x0000FF00) != 0) return 1;
            if ((x & 0x00FF0000) != 0) return 2;
            if ((x & 0xFF000000) != 0) return 3;
            return 4;
        }
        private static int GetNonZeroOctetIndexLE(ulong x)
        {
            if ((x & 0x00000000000000FFUL) != 0) return 0;
            if ((x & 0x000000000000FF00UL) != 0) return 1;
            if ((x & 0x0000000000FF0000UL) != 0) return 2;
            if ((x & 0x00000000FF000000UL) != 0) return 3;
            if ((x & 0x000000FF00000000UL) != 0) return 4;
            if ((x & 0x0000FF0000000000UL) != 0) return 5;
            if ((x & 0x00FF000000000000UL) != 0) return 6;
            if ((x & 0xFF00000000000000UL) != 0) return 7;
            return 8;
        }
#endif

        private static delegate*<uint, int> GetNonZeroOctetIndex32;
        private static delegate*<ulong, int> GetNonZeroOctetIndex64;
        public static int GetNonZeroOctetIndex(uint x) => GetNonZeroOctetIndex32(x);
        public static int GetNonZeroOctetIndex(ulong x) => GetNonZeroOctetIndex64(x);

        static BitHack()
        {
            if (BitConverter.IsLittleEndian)
            {
                GetNonZeroOctetIndex32 = &GetNonZeroOctetIndexLE;
                GetNonZeroOctetIndex64 = &GetNonZeroOctetIndexLE;
            }
            else
            {
                GetNonZeroOctetIndex32 = &GetNonZeroOctetIndexBE;
                GetNonZeroOctetIndex64 = &GetNonZeroOctetIndexBE;
            }
        }
    }
}
