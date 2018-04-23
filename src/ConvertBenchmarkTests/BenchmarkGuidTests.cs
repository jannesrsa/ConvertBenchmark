﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class BenchmarkGuidTests
    {
        [TestMethod()]
        public void ChangeTypeWithReflectionTest()
        {
            // Assert
            var benchmarkGuid = new BenchmarkGuid();

            // Action
            var result = benchmarkGuid.ChangeTypeWithReflection();
        }

        [TestMethod()]
        public void ChangeTypeWithGenericTest()
        {
            // Assert
            var benchmarkGuid = new BenchmarkGuid();

            // Action
            var result = benchmarkGuid.ChangeTypeWithGeneric();
        }

        [TestMethod()]
        public void ChangeTypeWithGeneric_StringTest()
        {
            // Assert
            var benchmarkGuid = new BenchmarkGuid();

            // Action
            var result = benchmarkGuid.ChangeTypeWithGeneric_String();
        }

        [TestMethod()]
        public void ChangeTypeWithReflection_StringTest()
        {
            // Assert
            var benchmarkGuid = new BenchmarkGuid();

            // Action
            var result = benchmarkGuid.ChangeTypeWithReflection_String();
        }
    }
}