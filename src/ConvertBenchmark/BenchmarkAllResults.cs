using System;
using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace ConvertBenchmark
{
    [MinColumn]
    [MaxColumn]
    [HtmlExporter]
    [CsvMeasurementsExporter]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchmarkAllResults
    {
        private const int LoadCount = 1000;

        public static Int32 Int32Value { get; } = Int32.MaxValue;

        public static string Int32StringValue { get; } = Int32.MaxValue.ToString();

        public static Int16 Int16Value { get; } = Int16.MaxValue;
        public static string Int16StringValue { get; } = Int16.MaxValue.ToString();

        public static Int64 Int64Value { get; } = Int64.MaxValue;

        public static string Int64StringValue { get; } = Int64.MaxValue.ToString();

        public static bool BoolValue { get; } = true;

        public static string BoolStringValue { get; } = bool.TrueString;

        public static Decimal DecimalValue { get; } = Decimal.MaxValue;

        public static string DecimalStringValue { get; } = Decimal.MaxValue.ToString();

        public static DateTime DateTimeValue { get; } = DateTime.MaxValue;

        public static string DateTimeStringValue { get; } = DateTime.MaxValue.ToString();

        public static Guid GuidValue { get; } = Guid.NewGuid();

        public static string GuidStringValue { get; } = Guid.NewGuid().ToString();

        public static string StringValue { get; } = Guid.NewGuid().ToString();

        [Benchmark]
        public void ChangeTypeWithReflection()
        {
            for (int i = 0; i < 1; i++)
            {
                var typedDateTime = DateTimeValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = StringValue.ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedIntString = Int32Value.ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16Value.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32Value.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64Value.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeTypeWithGeneric()
        {
            for (int i = 0; i < 1; i++)
            {
                var typedDateTime = DateTimeValue.ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = DecimalValue.ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = StringValue.ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = GuidValue.ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = Int16Value.ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = Int32Value.ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = Int64Value.ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = BoolValue.ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeTypeWithReflection_String()
        {
            for (int i = 0; i < 1; i++)
            {
                var typedDateTime = DateTimeStringValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalStringValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedIntString = Int32Value.ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidStringValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16StringValue.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32StringValue.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64StringValue.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolStringValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeTypeWithGeneric_String()
        {
            for (int i = 0; i < 1; i++)
            {
                var typedDateTime = DateTimeStringValue.ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = DecimalStringValue.ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = Int32Value.ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = GuidStringValue.ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = Int16StringValue.ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = Int32StringValue.ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = Int64StringValue.ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = BoolStringValue.ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeType_Load_Reflection()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = StringValue.ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16Value.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32Value.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64Value.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeType_Load_Generic()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeValue.ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = DecimalValue.ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = StringValue.ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = GuidValue.ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = Int16Value.ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = Int32Value.ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = Int64Value.ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = BoolValue.ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeType_Load_Reflection_String()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeStringValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalStringValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = Int32Value.ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidStringValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16StringValue.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32StringValue.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64StringValue.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolStringValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeType_Load_Generic_String()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeStringValue.ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = DecimalStringValue.ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = Int32Value.ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = GuidStringValue.ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = Int16StringValue.ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = Int32StringValue.ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = Int64StringValue.ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = BoolStringValue.ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }
    }
}