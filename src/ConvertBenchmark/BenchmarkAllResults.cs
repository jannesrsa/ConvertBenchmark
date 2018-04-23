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
    [CsvMeasurementsExporter]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchmarkAllResults
    {
        [Benchmark]
        public void ChangeTypeWithGeneric()
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

        [Benchmark]
        public void ChangeTypeWithGeneric_String()
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

        [Benchmark]
        public void ChangeTypeWithReflection()
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

        [Benchmark]
        public void ChangeTypeWithReflection_String()
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
}