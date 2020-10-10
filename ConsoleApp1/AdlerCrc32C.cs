

/* crc32c.c -- compute CRC-32C using the Intel crc32 instruction
 * Copyright (C) 2013 Mark Adler
 * Version 1.1  1 Aug 2013  Mark Adler
 */

/*
  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the author be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.

  Mark Adler
  madler@alumni.caltech.edu
 */

/* Use hardware CRC instruction on Intel SSE 4.2 processors.  This computes a
   CRC-32C, *not* the CRC-32 used by Ethernet and zip, gzip, etc.  A software
   version is provided as a fall-back, as well as for speed comparisons. */

/* Version history:
   1.0  10 Feb 2013  First version
   1.1   1 Aug 2013  Correct comments on why three crc instructions in parallel
 */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;


using uint32_t = System.UInt32;
using size_t = System.Int32;

namespace ConsoleApp1
{
    public unsafe class AdlerCrc32C
    {
        /* Table for a quadword-at-a-time software crc. */
        private static readonly uint* table;
        /* CRC-32C (iSCSI) polynomial in reversed bit order. */
        private const uint POLY = 0x82f63b78u;

        private static readonly bool sse42_x64 = Sse42.X64.IsSupported;
        private static readonly bool sse42 = Sse42.IsSupported;

        /* Construct table for software CRC-32C calculation. */
        static AdlerCrc32C()
        {
            table = (uint*)Marshal.AllocHGlobal(16 * 256 * 4);
            for (uint i = 0; i < 256; i++)
            {
                uint res = i;
                for (int t = 0; t < 16; t++)
                {
                    for (int k = 0; k < 8; k++) res = (res & 1) == 1 ? POLY ^ (res >> 1) : (res >> 1);
                    table[(t * 256) + i] = res;
                }
            }
        }

        /* Table-driven software version as a fall-back.  This is about 15 times slower
   than using the hardware instructions.  This assumes little-endian integers,
   as is the case on Intel processors that the assembler code here is for. */
        static uint crc32c_sw(uint crci, void* buf, int len)
        {
            byte* next = (byte*)buf;
            ulong crc;

            crc = crci ^ 0xffffffff;
            while (len != 0 && ((ulong)next & 7) != 0)
            {
                crc = table[(0 * 256) + ((crc ^ *next++) & 0xff)] ^ (crc >> 8);
                len--;
            }
            while (len >= 8)
            {
                crc ^= *(ulong*)next;
                crc = table[(7 * 256) + (crc & 0xff)] ^
                      table[(6 * 256) + ((crc >> 8) & 0xff)] ^
                      table[(5 * 256) + ((crc >> 16) & 0xff)] ^
                      table[(4 * 256) + ((crc >> 24) & 0xff)] ^
                      table[(3 * 256) + ((crc >> 32) & 0xff)] ^
                      table[(2 * 256) + ((crc >> 40) & 0xff)] ^
                      table[(1 * 256) + ((crc >> 48) & 0xff)] ^
                      table[(0 * 256) + (crc >> 56)];
                next += 8;
                len -= 8;
            }
            while (len != 0)
            {
                crc = table[(0 * 256) + ((crc ^ *next++) & 0xff)] ^ (crc >> 8);
                len--;
            }
            return (uint)crc ^ 0xffffffff;
        }

        /* Multiply a matrix times a vector over the Galois field of two elements,
   GF(2).  Each element is a bit in an unsigned integer.  mat must have at
   least as many entries as the power of two for most significant one bit in
   vec. */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static uint32_t gf2_matrix_times(uint32_t* mat, uint32_t vec)
        {
            uint32_t sum;

            sum = 0;
            while (vec != 0)
            {
                if ((vec & 1) != 0)
                    sum ^= *mat;
                vec >>= 1;
                mat++;
            }
            return sum;
        }

        /* Multiply a matrix by itself over GF(2).  Both mat and square must have 32
   rows. */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static void gf2_matrix_square(uint32_t* square, uint32_t* mat)
        {
            int n;

            for (n = 0; n < 32; n++)
                square[n] = gf2_matrix_times(mat, mat[n]);
        }

        /* Construct an operator to apply len zeros to a crc.  len must be a power of
   two.  If len is not a power of two, then the result is the same as for the
   largest power of two less than len.  The result for len == 0 is the same as
   for len == 1.  A version of this routine could be easily written for any
   len, but that is not needed for this application. */
        static void crc32c_zeros_op(uint32_t* even, size_t len)
        {
            int n;
            uint32_t row;
            var odd = stackalloc uint32_t[32];
            // uint32_t odd[32];       /* odd-power-of-two zeros operator */

            /* put operator for one zero bit in odd */
            odd[0] = POLY;              /* CRC-32C polynomial */
            row = 1;
            for (n = 1; n < 32; n++)
            {
                odd[n] = row;
                row <<= 1;
            }

            /* put operator for two zero bits in even */
            gf2_matrix_square(even, odd);

            /* put operator for four zero bits in odd */
            gf2_matrix_square(odd, even);

            /* first square will put the operator for one zero byte (eight zero bits),
               in even -- next square puts operator for two zero bytes in odd, and so
               on, until len has been rotated down to zero */
            do
            {
                gf2_matrix_square(even, odd);
                len >>= 1;
                if (len == 0)
                    return;
                gf2_matrix_square(odd, even);
                len >>= 1;
            } while (len!= 0);

            /* answer ended up in odd -- copy to even */
            for (n = 0; n < 32; n++)
                even[n] = odd[n];
        }

        /* Take a length and build four lookup tables for applying the zeros operator
   for that length, byte-by-byte on the operand. */
        static void crc32c_zeros(uint32_t* zeros, size_t len)
        {
            uint32_t n;
            var op = stackalloc uint32_t[32];
            // uint32_t op[32];

            crc32c_zeros_op(op, len);
            for (n = 0; n < 256; n++)
            {
                zeros[0 * 256 + n] = gf2_matrix_times(op, n);
                zeros[1 * 256 + n] = gf2_matrix_times(op, n << 8);
                zeros[2 * 256 + n] = gf2_matrix_times(op, n << 16);
                zeros[3 * 256 + n] = gf2_matrix_times(op, n << 24);
            }
        }

        /* Apply the zeros operator table to crc. */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static uint32_t crc32c_shift(uint32_t* zeros, uint32_t crc)
        {
            return zeros[0 * 256 + (crc & 0xff)] ^ zeros[1 * 256 + ((crc >> 8) & 0xff)] ^
                   zeros[2 * 256 + ((crc >> 16) & 0xff)] ^ zeros[3 * 256 + (crc >> 24)];
        }


    }
}
