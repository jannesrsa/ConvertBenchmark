using System;
using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using static ConvertBenchmark.Constants;

namespace ConvertBenchmark
{
    [MinColumn]
    [MaxColumn]
    [HtmlExporter]
    [MemoryDiagnoser]
    public class BenchmarkWithType
    {
        [Benchmark]
        public void ChangeType_bool()
        {
            var typedBool = BoolValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_DateTime()
        {
            var typedDateTime = DateTimeValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_Decimal()
        {
            var typedDecimal = DecimalValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_Guid()
        {
            var typedGuid = GuidValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_Int16()
        {
            var typedInt16 = Int16Value.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_Int32()
        {
            var typedInt32 = Int32Value.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_Int64()
        {
            var typedInt64 = Int64Value.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_NullableLong()
        {
            var typedNullableInt64 = NullableInt64Value.ChangeType(typeof(long?), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeType_String()
        {
            var typedString = StringValue.ChangeType(typeof(String), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_bool()
        {
            var typedBool = BoolValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_DateTime()
        {
            var typedDateTime = DateTimeValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_Decimal()
        {
            var typedDecimal = DecimalValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_Guid()
        {
            var typedGuid = GuidValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_Int16()
        {
            var typedInt16 = Int16Value.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_Int32()
        {
            var typedInt32 = Int32Value.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_Int64()
        {
            var typedInt64 = Int64Value.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_NullableLong()
        {
            var typedNullableInt64 = NullableInt64Value.ChangeTypeWithType(typeof(long?), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public void ChangeTypeWithType_String()
        {
            var typedString = StringValue.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
        }
    }
}