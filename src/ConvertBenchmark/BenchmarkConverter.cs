using System;
using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;

namespace ConvertBenchmark
{
    [ClrJob(isBaseline: true), CoreJob, MonoJob]
    [RPlotExporter, RankColumn]
    public class BenchmarkConverter
    {
        [Params(int.MinValue, int.MaxValue)]
        public int IntValue { get; set; }

        [Params("", "StringValue")]
        public string StringValue { get; set; }

        public DateTime DateTimeValue { get; set; } = DateTime.MaxValue;

        [Benchmark]
        public object ChangeTypeWithReflection_Int() => Converter.ChangeType(IntValue, typeof(int), CultureInfo.CurrentCulture);

        [Benchmark]
        public int ChangeTypeWithGeneric_Int() => Converter.ChangeType<int>(IntValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection_String() => Converter.ChangeType(StringValue, typeof(string), CultureInfo.CurrentCulture);

        [Benchmark]
        public string ChangeTypeWithGeneric_String() => Converter.ChangeType<string>(StringValue, CultureInfo.CurrentCulture);

        [Benchmark]
        public object ChangeTypeWithReflection_DateTime() => Converter.ChangeType(DateTimeValue, typeof(DateTime), CultureInfo.CurrentCulture);

        [Benchmark]
        public DateTime ChangeTypeWithGeneric_DateTime() => Converter.ChangeType<DateTime>(DateTimeValue, CultureInfo.CurrentCulture);
    }
}