using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class BenchmarkIntTests
    {
        [TestMethod()]
        public void ChangeTypeWithReflectionTest()
        {
            // Assert
            var benchmarkInt = new BenchmarkInt();

            // Action
            var result = benchmarkInt.ChangeTypeWithReflection();
        }

        [TestMethod()]
        public void ChangeTypeWithGenericTest()
        {
            // Assert
            var benchmarkInt = new BenchmarkInt();

            // Action
            var result = benchmarkInt.ChangeTypeWithGeneric();
        }

        [TestMethod()]
        public void ChangeTypeWithGeneric_StringTest()
        {
            // Assert
            var benchmarkInt = new BenchmarkInt();

            // Action
            var result = benchmarkInt.ChangeTypeWithGeneric_String();
        }

        [TestMethod()]
        public void ChangeTypeWithReflection_StringTest()
        {
            // Assert
            var benchmarkInt = new BenchmarkInt();

            // Action
            var result = benchmarkInt.ChangeTypeWithReflection_String();
        }
    }
}