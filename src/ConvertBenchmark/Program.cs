using System;
using BenchmarkDotNet.Running;

namespace ConvertBenchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summaryString = BenchmarkRunner.Run<BenchmarkString>();
            var summaryInt = BenchmarkRunner.Run<BenchmarkInt>();
            var summaryDateTime = BenchmarkRunner.Run<BenchmarkDateTime>();

            Console.ReadKey();
        }
    }
}