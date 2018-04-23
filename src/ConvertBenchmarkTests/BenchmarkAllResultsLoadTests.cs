using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class BenchmarkAllResultsLoadTests
    {
        [TestMethod()]
        public void ChangeType_Load_Generic_StringTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeType_With_Generic_StringValues_Load();
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
        public void ChangeType_Load_Reflection_StringTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeType_With_Reflection_StringValues_Load();
        }

        [TestMethod()]
        public void ChangeType_Load_ReflectionTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeType_With_Reflection_Load();
        }

        [TestMethod()]
        public void ChangeTypeWithType_IgnoreCultureWhenSameType_Load_Test()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeTypeWithType_IgnoreCultureWhenSameType_Load();
        }

        [TestMethod()]
        public void ChangeTypeWithType_Load_Test()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeTypeWithType_Load();
        }

        [TestMethod()]
        public void ChangeTypeWithType_StringValues_Load_Test()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.ChangeTypeWithType_StringValues_Load();
        }

        [TestMethod()]
        public void Convert_BaseLine_BoxingTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.Convert_BaseLine_Boxing();
        }

        [TestMethod()]
        public void Convert_BaseLine_StringTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.Convert_BaseLine_String();
        }

        [TestMethod()]
        public void Convert_BaseLine_TypedTest()
        {
            // Assert
            var benchmarkAllResults = new BenchmarkAllResultsLoad();

            // Action
            benchmarkAllResults.Convert_BaseLine_Typed();
        }
    }
}