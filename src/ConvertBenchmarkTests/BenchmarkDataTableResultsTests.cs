using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class BenchmarkDataTableResultsTests
    {
        [TestMethod()]
        public void ChangeTypeWithReflectionTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkDataTableResults();

            // Action
            benchmarkAllResults.ChangeTypeWithReflection();
        }

        [TestMethod()]
        public void ChangeTypeWithGenericTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkDataTableResults();

            // Action
            benchmarkAllResults.ChangeTypeWithGeneric();
        }

        [TestMethod()]
        public void ChangeTypeWithGeneric_StringTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkDataTableResults();

            // Action
            benchmarkAllResults.ChangeTypeWithGeneric_String();
        }

        [TestMethod()]
        public void ChangeTypeWithReflection_StringTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkDataTableResults();

            // Action
            benchmarkAllResults.ChangeTypeWithReflection_String();
        }
    }
}