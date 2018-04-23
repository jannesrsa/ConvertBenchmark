using System;
using System.Globalization;

namespace ConvertBenchmark
{
    public static class Constants
    {
        static Constants()
        {
            BoolValue = true;
            DateTimeValue = DateTime.Parse(DateTime.MaxValue.ToString(), CultureInfo.InvariantCulture);
            DecimalValue = Decimal.MaxValue;
            GuidValue = Guid.NewGuid();
            Int16Value = Int16.MaxValue;
            Int32Value = Int32.MaxValue;
            Int64Value = Int64.MaxValue;
            StringValue = Guid.NewGuid().ToString();

            BoolStringValue = BoolValue.ToString();
            DateTimeStringValue = DateTimeValue.ToString();
            DecimalStringValue = DecimalValue.ToString();
            GuidStringValue = GuidValue.ToString();
            Int16StringValue = Int16Value.ToString();
            Int32StringValue = Int32Value.ToString();
            Int64StringValue = Int64Value.ToString();
        }

        public static string BoolStringValue { get; } 
        public static bool BoolValue { get; }
        public static string DateTimeStringValue { get; }
        public static DateTime DateTimeValue { get; }
        public static string DecimalStringValue { get; }
        public static Decimal DecimalValue { get; }
        public static string GuidStringValue { get; } 
        public static Guid GuidValue { get; }
        public static string Int16StringValue { get; } 
        public static Int16 Int16Value { get; }
        public static string Int32StringValue { get; } 
        public static Int32 Int32Value { get; }
        public static string Int64StringValue { get; } 
        public static Int64 Int64Value { get; }
        public static string StringValue { get; } 
    }
}