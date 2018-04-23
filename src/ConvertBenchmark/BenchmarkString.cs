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
        public string StringValue { get; } = Guid.NewGuid().ToString();

        [Benchmark(Baseline = true)]
        public string ChangeTypeWithGeneric() => Converter.ChangeType<string>(StringValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection() => Converter.ChangeType(StringValue, typeof(string), CultureInfo.CurrentCulture);
    }
}