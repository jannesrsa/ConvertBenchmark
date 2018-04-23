using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class BenchmarkAllResultsLoadTests
    {

        [TestMethod()]
        public void ChangeType_Load_ReflectionTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeType_With_Reflection_Load();
        }

        [TestMethod()]
        public void ChangeType_Load_GenericTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeType_With_Generic_Load();
        }

        [TestMethod()]
        public void ChangeType_Load_Generic_StringTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeType_With_Generic_StringValues_Load();
        }

        [TestMethod()]
        public void ChangeType_Load_Reflection_StringTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeType_With_Reflection_StringValues_Load();
        }
    }
}