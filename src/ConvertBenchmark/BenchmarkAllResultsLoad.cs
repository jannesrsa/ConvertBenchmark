﻿using System;
using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using static ConvertBenchmark.Constants;

namespace ConvertBenchmark
{
    [MinColumn]
    [MaxColumn]
    [HtmlExporter]
    [MemoryDiagnoser]
    public class BenchmarkAllResultsLoad
    {
        private const int LoadCount = 1000;

        [Benchmark]
        public void ChangeType_With_Generic_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeValue.ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = DecimalValue.ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = StringValue.ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = GuidValue.ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = Int16Value.ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = Int32Value.ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = Int64Value.ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = BoolValue.ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeType_With_Generic_StringValues_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeStringValue.ChangeType<DateTime>(CultureInfo.InvariantCulture);
                var typedDecimal = DecimalStringValue.ChangeType<Decimal>(CultureInfo.InvariantCulture);
                var typedString = Int32Value.ChangeType<String>(CultureInfo.InvariantCulture);
                var typedGuid = GuidStringValue.ChangeType<Guid>(CultureInfo.InvariantCulture);
                var typedInt16 = Int16StringValue.ChangeType<Int16>(CultureInfo.InvariantCulture);
                var typedInt32 = Int32StringValue.ChangeType<Int32>(CultureInfo.InvariantCulture);
                var typedInt64 = Int64StringValue.ChangeType<Int64>(CultureInfo.InvariantCulture);
                var typedBool = BoolStringValue.ChangeType<bool>(CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeType_With_Reflection_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = StringValue.ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16Value.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32Value.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64Value.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeType_With_Reflection_StringValues_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeStringValue.ChangeType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalStringValue.ChangeType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = Int32Value.ChangeType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidStringValue.ChangeType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16StringValue.ChangeType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32StringValue.ChangeType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64StringValue.ChangeType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolStringValue.ChangeType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeTypeWithType_IgnoreCultureWhenSameType_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture, true);
                var typedDecimal = DecimalValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture, true);
                var typedString = StringValue.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture, true);
                var typedGuid = GuidValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture, true);
                var typedInt16 = Int16Value.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture, true);
                var typedInt32 = Int32Value.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture, true);
                var typedInt64 = Int64Value.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture, true);
                var typedBool = BoolValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture, true);
            }
        }

        [Benchmark]
        public void ChangeTypeWithType_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = StringValue.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16Value.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32Value.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64Value.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }

        [Benchmark]
        public void ChangeTypeWithType_StringValues_Load()
        {
            for (int i = 0; i < LoadCount; i++)
            {
                var typedDateTime = DateTimeStringValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
                var typedDecimal = DecimalStringValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
                var typedString = Int32Value.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
                var typedGuid = GuidStringValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
                var typedInt16 = Int16StringValue.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
                var typedInt32 = Int32StringValue.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
                var typedInt64 = Int64StringValue.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
                var typedBool = BoolStringValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
                var typedEmptyBool = string.Empty.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
            }
        }
    }
}