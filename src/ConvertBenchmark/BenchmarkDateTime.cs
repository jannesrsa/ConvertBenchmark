using System;
using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;

namespace ConvertBenchmark
{
    [ClrJob(isBaseline: true)]
    [MinColumn]
    [MaxColumn]
    [HtmlExporter]
    [CsvMeasurementsExporter]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchmarkDateTime
    {
        public DateTime DateTimeValue { get; set; } = DateTime.MaxValue;

        [Benchmark]
        public object ChangeTypeWithReflection() => Converter.ChangeType(DateTimeValue, typeof(DateTime), CultureInfo.CurrentCulture);

        [Benchmark]
        public DateTime ChangeTypeWithGeneric() => Converter.ChangeType<DateTime>(DateTimeValue, CultureInfo.CurrentCulture);
    }
}