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
    public class BenchmarkString
    {
        public static string StringValue { get; } = Guid.NewGuid().ToString();

        [Benchmark]
        public string ChangeTypeWithGeneric() => Converter.ChangeType<string>(StringValue, CultureInfo.CurrentCulture);

        [Benchmark(Baseline = true)]
        public object ChangeTypeWithReflection() => Converter.ChangeType(StringValue, typeof(string), CultureInfo.CurrentCulture);
    }
}