using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class BenchmarkDateTimeTests
    {
        [TestMethod()]
        public void ChangeTypeWithReflectionTest()
        {
            // Assert
            var benchmarkDateTime = new BenchmarkDateTime();

            // Action
            var result = benchmarkDateTime.ChangeTypeWithReflection();
        }

        [TestMethod()]
        public void ChangeTypeWithGenericTest()
        {
            // Assert
            var benchmarkDateTime = new BenchmarkDateTime();

            // Action
            var result = benchmarkDateTime.ChangeTypeWithGeneric();
        }

        [TestMethod()]
        public void ChangeTypeWithGeneric_StringTest()
        {
            // Assert
            var benchmarkDateTime = new BenchmarkDateTime();

            // Action
            var result = benchmarkDateTime.ChangeTypeWithGeneric_String();
        }

        [TestMethod()]
        public void ChangeTypeWithReflection_StringTest()
        {
            // Assert
            var benchmarkDateTime = new BenchmarkDateTime();

            // Action
            var result = benchmarkDateTime.ChangeTypeWithReflection_String();
        }
    }
}