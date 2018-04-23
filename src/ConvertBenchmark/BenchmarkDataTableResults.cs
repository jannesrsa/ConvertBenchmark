using System;
using System.Data;
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
    public class BenchmarkDataTableResults
    {
        [Benchmark(Baseline = true)]
        public void ChangeTypeWithGeneric()
        {
            var dataReader = new DataTableReader(TestData.DataTable);

            while (dataReader.Read())
            {
                var typedDateTime = dataReader[0].ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = dataReader[1].ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = dataReader[2].ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = dataReader[3].ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = dataReader[4].ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = dataReader[5].ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = dataReader[6].ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = dataReader[7].ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeTypeWithGeneric_String()
        {
            var dataReader = new DataTableReader(TestData.StringDataTable);

            while (dataReader.Read())
            {
                var typedDateTime = dataReader[0].ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = dataReader[1].ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = dataReader[2].ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = dataReader[3].ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = dataReader[4].ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = dataReader[5].ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = dataReader[6].ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = dataReader[7].ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeTypeWithReflection()
        {
            var dataReader = new DataTableReader(TestData.DataTable);

            while (dataReader.Read())
            {
                //Add SmartObject Properties...
                for (var fieldIndex = 0; fieldIndex < dataReader.FieldCount; fieldIndex++)
                {
                    //Add Property Value -->
                    object value = dataReader[fieldIndex];
                    var typedValue = value.ChangeType(value.GetType(), CultureInfo.InvariantCulture);
                }
            }
        }

        [Benchmark]
        public void ChangeTypeWithReflection_String()
        {
            var dataReader = new DataTableReader(TestData.StringDataTable);

            while (dataReader.Read())
            {
                var typedDateTime = dataReader[0].ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = dataReader[1].ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = dataReader[2].ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = dataReader[3].ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = dataReader[4].ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = dataReader[5].ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = dataReader[6].ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = dataReader[7].ChangeType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }
    }
}