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
    public class BenchmarkInt
    {
        [Params(int.MinValue, 0, int.MaxValue)]
        public int IntValue { get; set; }

        [Benchmark]
        public object ChangeTypeWithReflection() => Converter.ChangeType(IntValue, typeof(int), CultureInfo.CurrentCulture);

        [Benchmark]
        public int ChangeTypeWithGeneric() => Converter.ChangeType<int>(IntValue, CultureInfo.CurrentCulture);
    }
}