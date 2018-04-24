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
    public class BenchmarkConverter
    {
        [Benchmark]
        public object ChangeType_bool()
        {
            return BoolValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_bool_FromString()
        {
            return BoolStringValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_DateTime()
        {
            return DateTimeValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_DateTime_FromString()
        {
            return DateTimeStringValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Decimal()
        {
            return DecimalValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Decimal_FromString()
        {
            return DecimalStringValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Guid()
        {
            return GuidValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Guid_FromString()
        {
            return GuidStringValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int16()
        {
            return Int16Value.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int16_FromString()
        {
            return Int16StringValue.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int32()
        {
            return Int32Value.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int32_FromString()
        {
            return Int32StringValue.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int64()
        {
            return Int64Value.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_Int64_FromString()
        {
            return Int64StringValue.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_NullableLong()
        {
            return NullableInt64Value.ChangeType(typeof(long?), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeType_NullableLong_FromString()
        {
            return NullableInt64StringValue.ChangeType(typeof(long?), CultureInfo.InvariantCulture);
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
        public object ChangeTypeWithType_bool_FromString()
        {
            return BoolStringValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_DateTime()
        {
            return DateTimeValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_DateTime_FromString()
        {
            return DateTimeStringValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Decimal()
        {
            return DecimalValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Decimal_FromString()
        {
            return DecimalStringValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Guid()
        {
            return GuidValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Guid_FromString()
        {
            return GuidStringValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int16()
        {
            return Int16Value.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int16_FromString()
        {
            return Int16StringValue.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int32()
        {
            return Int32Value.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int32_FromString()
        {
            return Int32StringValue.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int64()
        {
            return Int64Value.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_Int64_FromString()
        {
            return Int64StringValue.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_NullableLong()
        {
            return NullableInt64Value.ChangeTypeWithType(typeof(long?), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_NullableLong_FromString()
        {
            return NullableInt64StringValue.ChangeTypeWithType(typeof(long?), CultureInfo.InvariantCulture);
        }

        [Benchmark]
        public object ChangeTypeWithType_String()
        {
            return StringValue.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
        }
    }
}