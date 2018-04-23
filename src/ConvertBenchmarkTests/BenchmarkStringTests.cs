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
    public class BenchmarkStringTests
    {
        [TestMethod()]
        public void ChangeTypeWithReflectionTest()
        {
            // Assert
            var benchmarkString = new BenchmarkString();

            // Action
            var result = benchmarkString.ChangeTypeWithReflection();
        }

        [TestMethod()]
        public void ChangeTypeWithGenericTest()
        {
            // Assert
            var benchmarkString = new BenchmarkString();

            // Action
            var result = benchmarkString.ChangeTypeWithGeneric();
        }
    }
}