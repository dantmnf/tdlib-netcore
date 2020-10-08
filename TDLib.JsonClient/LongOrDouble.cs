using System;

namespace TDLib.JsonClient
{
    internal enum LongOrDoubleValueType { Invalid, Long, Double };

    internal struct LongOrDouble
    {
        private long value;
        private readonly LongOrDoubleValueType type;

        public static LongOrDouble FromLong(long x) => new LongOrDouble(x);
        public static LongOrDouble FromDouble(double x) => new LongOrDouble(x);

        private LongOrDouble(long longVvalue)
        {
            value = longVvalue;
            type = LongOrDoubleValueType.Long;
        }
        private LongOrDouble(double doubleValue)
        {
            value = DoubleToLongBits(doubleValue);
            type = LongOrDoubleValueType.Double;
        }

        public LongOrDoubleValueType ValueType => type;
        public long GetLong() => type switch
        {
            LongOrDoubleValueType.Long => value,
            LongOrDoubleValueType.Double => (long)LongBitsToDouble(value),
            _ => throw new InvalidOperationException($"{nameof(LongOrDouble)} has no valid value"),
        };

        public double GetDouble() => type switch
        {
            LongOrDoubleValueType.Long => (double)value,
            LongOrDoubleValueType.Double => LongBitsToDouble(value),
            _ => throw new InvalidOperationException($"{nameof(LongOrDouble)} has no valid value"),
        };

        public static explicit operator long(LongOrDouble x) => x.GetLong();

        public static explicit operator double(LongOrDouble x) => x.GetDouble();

        private static unsafe long DoubleToLongBits(double d)
        {
            return *((long*)(void*)&d);
        }
        private static unsafe double LongBitsToDouble(long d)
        {
            return *((double*)(void*)&d);
        }
    }
}
