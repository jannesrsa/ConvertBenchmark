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
    public class BenchmarkGuid
    {
        public static Guid GuidValue { get; } = Guid.NewGuid();
        public static string StringGuidValue { get; } = Guid.NewGuid().ToString();

        [Benchmark(Baseline = true)]
        public Guid ChangeTypeWithGeneric() => Converter.ChangeType<Guid>(GuidValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public Guid ChangeTypeWithGeneric_String() => Converter.ChangeType<Guid>(StringGuidValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection() => Converter.ChangeType(GuidValue, typeof(Guid), CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection_String() => Converter.ChangeType(StringGuidValue, typeof(Guid), CultureInfo.CurrentCulture);
    }
}