using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertBenchmark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class BenchmarkParameterBufferTests
    {
        [TestMethod()]
        public void BenchmarkParameterBuffer_ParameterBuffer_string_Test()
        {
            // Assert
            var benchmarkParameterBuffer = new BenchmarkParameterBuffer();

            // Action
            var value = benchmarkParameterBuffer.ParameterBuffer_string();
        }

        [TestMethod()]
        public void BenchmarkParameterBuffer_Object_string_Test()
        {
             // Assert
            var benchmarkParameterBuffer = new BenchmarkParameterBuffer();

            // Action
            var value = benchmarkParameterBuffer.Object_string();
        }

        [TestMethod()]
        public void BenchmarkParameterBuffer_ParameterBuffer_int_Test()
        {
            // Assert
            var benchmarkParameterBuffer = new BenchmarkParameterBuffer();

            // Action
            var value = benchmarkParameterBuffer.ParameterBuffer_int();
        }

        [TestMethod()]
        public void BenchmarkParameterBuffer_Object_int_Test()
        {
            // Assert
            var benchmarkParameterBuffer = new BenchmarkParameterBuffer();

            // Action
            var value = benchmarkParameterBuffer.Object_int();
        }
    }
}