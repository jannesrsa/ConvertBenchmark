using System;

namespace ConvertBenchmark
{
    public static class Constants
    {
        public static string BoolStringValue { get; } = bool.TrueString;
        public static bool BoolValue { get; } = true;
        public static string DateTimeStringValue { get; } = DateTime.MaxValue.ToString();
        public static DateTime DateTimeValue { get; } = DateTime.MaxValue;
        public static string DecimalStringValue { get; } = Decimal.MaxValue.ToString();
        public static Decimal DecimalValue { get; } = Decimal.MaxValue;
        public static string GuidStringValue { get; } = Guid.NewGuid().ToString();
        public static Guid GuidValue { get; } = Guid.NewGuid();
        public static string Int16StringValue { get; } = Int16.MaxValue.ToString();
        public static Int16 Int16Value { get; } = Int16.MaxValue;
        public static string Int32StringValue { get; } = Int32.MaxValue.ToString();
        public static Int32 Int32Value { get; } = Int32.MaxValue;
        public static string Int64StringValue { get; } = Int64.MaxValue.ToString();
        public static Int64 Int64Value { get; } = Int64.MaxValue;
        public static string StringValue { get; } = Guid.NewGuid().ToString();
    }
}