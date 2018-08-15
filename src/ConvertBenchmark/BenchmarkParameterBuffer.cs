using System.Collections.Generic;
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
    public class BenchmarkParameterBuffer
    {
        [Benchmark]
        public IEnumerable<ParameterBuffer> ParameterBuffer_string()
        {
            var list = new List<ParameterBuffer>(1);
            list.Add(ParameterBuffer.Create(StringValue));
            return list;
        }

        [Benchmark]
        public object[] Object_string()
        {
            var array = new object[1];
            array[0] = StringValue;
            return array;
        }

        [Benchmark]
        public IEnumerable<ParameterBuffer> ParameterBuffer_int()
        {
            var list = new List<ParameterBuffer>(1);
            list.Add(ParameterBuffer.Create(Int32Value));
            return list;
        }

        [Benchmark]
        public object[] Object_int()
        {
            var array = new object[1];
            array[0] = Int32Value;
            return array;
        }
    }
}