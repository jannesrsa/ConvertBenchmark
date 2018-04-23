using System;
using BenchmarkDotNet.Running;

namespace ConvertBenchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var summaryString = BenchmarkRunner.Run<BenchmarkString>();
            //var summaryInt = BenchmarkRunner.Run<BenchmarkInt>();
            //var summaryGuid = BenchmarkRunner.Run<BenchmarkGuid>();
            //var summaryDateTime = BenchmarkRunner.Run<BenchmarkDateTime>();
            //var summaryDataTableResults = BenchmarkRunner.Run<BenchmarkDataTableResults>();
            //var summaryAllResults = BenchmarkRunner.Run<BenchmarkAllResults>();
            var summaryBenchmarkAllResultsLoad = BenchmarkRunner.Run<BenchmarkAllResultsLoad>();

            Console.ReadKey();
        }
    }
}
