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
        public object ChangeType_bool()
        {
            return BoolValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_DateTime()
        {
            return DateTimeValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Decimal()
        {
            return DecimalValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Guid()
        {
            return GuidValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int16()
        {
            return Int16Value.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int32()
        {
            return Int32Value.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int64()
        {
            return Int64Value.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_NullableLong()
        {
            return NullableInt64Value.ChangeType(typeof(long?), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_String()
        {
            return StringValue.ChangeType(typeof(String), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_bool()
        {
            return BoolValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_DateTime()
        {
            return DateTimeValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Decimal()
        {
            return DecimalValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Guid()
        {
            return GuidValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int16()
        {
            return Int16Value.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int32()
        {
            return Int32Value.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int64()
        {
            return Int64Value.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_NullableLong()
        {
            return NullableInt64Value.ChangeTypeWithType(typeof(long?), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_String()
        {
            return StringValue.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
        }
    }
}