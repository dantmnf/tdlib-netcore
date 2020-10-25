using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TDLib.NativeClient.ObjectBridge
{
    static unsafe class _MemberOffsets
    {
        private static uint* table;
        private static int length;

        static _MemberOffsets()
        {
            table = Native.td_bridge_offset_table(out var len2);
            length = (int) len2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr GetMemberAddress(IntPtr obj, _MemberOffsetIndex member)
        {
            var index = (int) member;
            if (index >= 0 && index < length)
            {
                return IntPtr.Add(obj, (int)table[index]);
            }
            throw new ArgumentOutOfRangeException(nameof(member));
        }
    }
}
