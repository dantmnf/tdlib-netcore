using System;
using System.Collections.Generic;
using System.Text;

namespace TDLib.Api
{
    static class ByteSpanBase64
    {

        // FIXME: broken
        

        private const string table = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@>@@@?456789:;<=@@@@@@@\0\u0001\u0002\u0003\u0004\u0005\u0006\a\b\t\n\v\f\r\u000e\u000f\u0010\u0011\u0012\u0013\u0014\u0015\u0016\u0017\u0018\u0019@@@@@@\u001a\u001b\u001c\u001d\u001e\u001f !\"#$%&'()*+,-./0123@@@@";

        private static int IndexOf(byte input)
        {
            var value = table[input];
            if (value == '@') throw new IndexOutOfRangeException();
            return value;
        }

        public static unsafe int GetDecodedLength(ReadOnlySpan<byte> input)
        {
            var inlen = input.Length;
            if (inlen == 0) return 0;
            var baselen = inlen / 4 * 3;

            switch (inlen % 4)
            {
                case 0:
                    var offset = input.Length - 1;
                    if (input[offset] == '=')
                    {
                        if (input[offset] == '=') return baselen - 2;
                        return baselen - 1;
                    }
                    return baselen;
                case 2:
                    return baselen + 1;
                case 3:
                    return baselen + 2;
                default: // case 1:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static (int inlen, int outlen) Decode4(ReadOnlySpan<byte> input, Span<byte> output)
        {
            unchecked
            {
                var offset = 0;
                var index0 = IndexOf(input[offset]);
                output[0] = (byte)((index0 << 2));
                offset++;
                var index1 = IndexOf(input[offset]);
                output[0] |= (byte)(index1 >> 4);
                offset++;
                if (offset < input.Length && input[offset] != '=')
                {
                    var index2 = IndexOf(input[offset]);
                    output[1] = (byte)((index1 << 4) | (index2 >> 2));
                    offset++;
                    if (offset < input.Length && input[offset] != '=')
                    {
                        var index3 = IndexOf(input[offset]);
                        output[2] = (byte)((index2 << 6) | index3);
                        return (offset+1, 3);
                    }
                    return (offset+1, 2);
                }
                return (offset+1, 1);
            }
        }

        public static int Decode(ReadOnlySpan<byte> input, Span<byte> output)
        {
            var len = GetDecodedLength(input);
            var inpos = 0;
            var outpos = 0;
            while (inpos < input.Length)
            {
                var (inlen, outlen) = Decode4(input.Slice(inpos), output.Slice(outpos));
                inpos += inlen;
                outpos += outlen;
            }
            return outpos;
        }
    }
}
