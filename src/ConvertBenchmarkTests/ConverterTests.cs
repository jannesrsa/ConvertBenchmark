using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ConvertBenchmark.Constants;

namespace ConvertBenchmark.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        [TestMethod()]
        public void Converter_ChangeTypeWithType_With_StringValues()
        {
            // DateTime
            var typedDateTime = DateTimeStringValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
            Assert.AreEqual(DateTimeValue, typedDateTime);

            var typedDecimal = DecimalStringValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
            Assert.AreEqual(DecimalValue, typedDecimal);

            // String
            var typedString = Int32Value.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int32Value.ToString(), typedString);

            var nullString = ((string)null).ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
            Assert.IsNull(nullString);

            // Guid
            var typedGuid = GuidStringValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
            Assert.AreEqual(GuidValue, typedGuid);

            // Int16
            var typedInt16 = Int16StringValue.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int16Value, typedInt16);

            // Int32
            var typedInt32 = Int32StringValue.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int32Value, typedInt32);

            // Int64
            var typedInt64 = Int64StringValue.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int64Value, typedInt64);

            var int32toInt64 = Int32Value.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
            Assert.AreEqual((long)Int32Value, int32toInt64);

            // Boolean
            var typedBool = BoolStringValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
            Assert.AreEqual(BoolValue, typedBool);

            var emptyStringBool = (bool)string.Empty.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
            Assert.IsFalse(emptyStringBool);

            var nullableStringBool = (bool)false.ToString().ChangeTypeWithType(typeof(bool?), CultureInfo.InvariantCulture);
            Assert.IsFalse(nullableStringBool);

            // Char
            var typedChar = 't'.ChangeTypeWithType(typeof(char), CultureInfo.InvariantCulture);
            Assert.AreEqual('t', typedChar);

            // Object
            var objectBool = BoolValue.ChangeTypeWithType(typeof(object), CultureInfo.InvariantCulture);
            Assert.AreEqual((object)BoolValue, objectBool);

            var boolObject = ((object)BoolValue).ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
            Assert.AreEqual((object)BoolValue, boolObject);

            // Enum
            var enumValue = NumberStyles.AllowCurrencySymbol.ToString().ChangeTypeWithType(typeof(NumberStyles), CultureInfo.InvariantCulture);
            Assert.AreEqual(enumValue, NumberStyles.AllowCurrencySymbol);

            // Invalid
            var invalidConversion = Int32Value.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int32Value, invalidConversion);
        }

        [TestMethod()]
        public void Converter_ChangeTypeWithType_With_TypeValues()
        {
            var typedDateTime = DateTimeValue.ChangeTypeWithType(typeof(DateTime), CultureInfo.InvariantCulture);
            Assert.AreEqual(DateTimeValue, typedDateTime);

            var typedDecimal = DecimalValue.ChangeTypeWithType(typeof(Decimal), CultureInfo.InvariantCulture);
            Assert.AreEqual(DecimalValue, typedDecimal);

            var typedString = StringValue.ChangeTypeWithType(typeof(String), CultureInfo.InvariantCulture);
            Assert.AreEqual(StringValue, typedString);

            var typedGuid = GuidValue.ChangeTypeWithType(typeof(Guid), CultureInfo.InvariantCulture);
            Assert.AreEqual(GuidValue, typedGuid);

            var typedInt16 = Int16Value.ChangeTypeWithType(typeof(Int16), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int16Value, typedInt16);

            var typedInt32 = Int32Value.ChangeTypeWithType(typeof(Int32), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int32Value, typedInt32);

            var typedInt64 = Int64Value.ChangeTypeWithType(typeof(Int64), CultureInfo.InvariantCulture);
            Assert.AreEqual(Int64Value, typedInt64);

            var typedBool = BoolValue.ChangeTypeWithType(typeof(bool), CultureInfo.InvariantCulture);
            Assert.AreEqual(BoolValue, typedBool);
        }
    }
}