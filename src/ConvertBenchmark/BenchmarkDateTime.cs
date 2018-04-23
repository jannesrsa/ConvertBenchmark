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
    public class BenchmarkDateTime
    {
        public static DateTime DateTimeValue { get; } = DateTime.MaxValue;

        public static string StringDateTimeValue { get; } = DateTime.MaxValue.ToString();

        [Benchmark]
        public object ChangeTypeWithReflection() => Converter.ChangeType(DateTimeValue, typeof(DateTime), CultureInfo.CurrentCulture);

        [Benchmark(Baseline = true)]
        public DateTime ChangeTypeWithGeneric() => Converter.ChangeType<DateTime>(DateTimeValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public DateTime ChangeTypeWithGeneric_String() => Converter.ChangeType<DateTime>(StringDateTimeValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection_String() => Converter.ChangeType(StringDateTimeValue, typeof(DateTime), CultureInfo.CurrentCulture);
    }
}