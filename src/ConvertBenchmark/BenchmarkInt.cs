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
    public class BenchmarkInt
    {
        public static int IntValue { get; } = 256;
        public static string StringIntValue { get; } = "256";

        [Benchmark]
        public object ChangeTypeWithReflection() => Converter.ChangeType(IntValue, typeof(int), CultureInfo.CurrentCulture);

        [Benchmark(Baseline = true)]
        public int ChangeTypeWithGeneric() => Converter.ChangeType<int>(IntValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public int ChangeTypeWithGeneric_String() => Converter.ChangeType<int>(StringIntValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection_String() => Converter.ChangeType(StringIntValue, typeof(int), CultureInfo.CurrentCulture);
    }
}