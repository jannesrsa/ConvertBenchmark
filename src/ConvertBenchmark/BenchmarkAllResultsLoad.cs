using System;
using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using static ConvertBenchmark.Constants;

namespace ConvertBenchmark
{
    [MinColumn]
    [MaxColumn]
    [HtmlExporter]
    [MemoryDiagnoser]
    public class BenchmarkAllResultsLoad
    {
        private const int LoadCount = 10;
        private static BenchmarkAllResults _benchmarkAllResults = new BenchmarkAllResults();

        [Benchmark]
        public void ChangeType_With_Generic_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.ChangeType_With_Generic();
            }
        }

        [Benchmark]
        public void ChangeType_With_Generic_StringValues_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.ChangeType_With_Generic_StringValues();
            }
        }

        [Benchmark]
        public void ChangeType_With_Reflection_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.ChangeType_With_Reflection();
            }
        }

        [Benchmark]
        public void ChangeType_With_Reflection_StringValues_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.ChangeType_With_Reflection_StringValues();
            }
        }

        [Benchmark]
        public void ChangeTypeWithType_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.ChangeTypeWithType();
            }
        }

        [Benchmark]
        public void ChangeTypeWithType_StringValues_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.ChangeTypeWithType_StringValues();
            }
        }

        [Benchmark]
        public void Convert_BaseLine_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.Convert_BaseLine();
            }
        }

        [Benchmark]
        public void Convert_BaseLine_String_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                _benchmarkAllResults.Convert_BaseLine_String();
            }
        }
    }
}