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
    public class BenchmarkString
    {
        [Params("", "StringValue")]
        public string StringValue { get; set; }

        [Benchmark]
        public string ChangeTypeWithGeneric() => Converter.ChangeType<string>(StringValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection() => Converter.ChangeType(StringValue, typeof(string), CultureInfo.CurrentCulture);
    }
}