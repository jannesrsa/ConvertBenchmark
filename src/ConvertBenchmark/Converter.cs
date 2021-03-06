﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace ConvertBenchmark
{
    /// <summary>
    /// Contains Extension method to handle custom convertions
    /// </summary>
    public static class Converter
    {
        private readonly static Type DateTimeOffsetType = typeof(DateTimeOffset);
        private readonly static Type DateTimeType = typeof(DateTime);
        private readonly static Type GuidType = typeof(Guid);
        private readonly static Type Int16Type = typeof(Int16);
        private readonly static Type Int32Type = typeof(Int32);
        private readonly static Type Int64Type = typeof(Int64);
        private readonly static Type NullableType = typeof(Nullable<>);
        private readonly static Type StringType = typeof(string);
        private readonly static Type TimeSpanType = typeof(TimeSpan);

        public static object ChangeType(this object value, Type toType, CultureInfo cultureInfo)
        {
            try
            {
                return typeof(Converter).GetMethod("ChangeType", new[] { typeof(object), typeof(CultureInfo) }).MakeGenericMethod(toType).Invoke(null, new object[] { value, cultureInfo });
            }
            catch
            {
                //In order to preserve potential backwards compatibility issues where values where passed into the smo.client api that does not match that properties system type
                //we need to default to just sending the value as a string object again
                return value;
            }
        }

        public static T ChangeType<T>(this object value, CultureInfo cultureInfo)
        {
            if (cultureInfo == null) throw new ArgumentNullException("cultureInfo");

            var toType = typeof(T);

            if (value == null) return default(T);

            if (value is string)
            {
                var strValue = (string)value;

                switch (Type.GetTypeCode(toType))
                {
                    case TypeCode.Int16:
                        Int16 parseInt16;
                        if (Int16.TryParse(TrimDecimalPart(strValue, cultureInfo), out parseInt16))
                        {
                            return ChangeType<T>(parseInt16, cultureInfo);
                        }
                        break;

                    case TypeCode.Int32:
                        Int32 parseInt32;
                        if (Int32.TryParse(TrimDecimalPart(strValue, cultureInfo), out parseInt32))
                        {
                            return ChangeType<T>(parseInt32, cultureInfo);
                        }
                        break;

                    case TypeCode.Int64:
                        //string with value "123.000" results in error 'Input string was not in a correct format' if directly attempted to convert to Int64
                        Int64 parseInt64;
                        if (Int64.TryParse(TrimDecimalPart(strValue, cultureInfo), out parseInt64))
                        {
                            return ChangeType<T>(parseInt64, cultureInfo);
                        }
                        break;

                    case TypeCode.DateTime:
                        DateTime parseDateTime;
                        if (DateTime.TryParse(strValue, out parseDateTime))
                        {
                            return ChangeType<T>(parseDateTime, cultureInfo);
                        }
                        else
                        {
                            //If the first try parse failed, we need to attempt to parse using all the avaliable dateTime Patterns.
                            if (DateTime.TryParseExact(strValue, cultureInfo.DateTimeFormat.GetAllDateTimePatterns(), cultureInfo, DateTimeStyles.None, out parseDateTime))
                            {
                                return ChangeType<T>(parseDateTime, cultureInfo);
                            }
                        }
                        break;

                    case TypeCode.String:
                        if (value.IsNullOrEmptyString())
                        {
                            return (T)value;
                        }
                        break;

                    default:
                        if (toType == typeof(Guid) && !string.IsNullOrEmpty(strValue))
                        {
                            return ChangeType<T>(new Guid(strValue), cultureInfo);
                        }
                        else if (toType == typeof(TimeSpan))
                        {
                            return ChangeType<T>(TimeSpan.Parse(strValue), cultureInfo);
                        }
                        else if (toType == typeof(DateTimeOffset))
                        {
                            return ChangeType<T>(DateTimeOffset.Parse(strValue), cultureInfo);
                        }
                        else if (strValue == string.Empty && toType != typeof(string))
                        {
                            return ChangeType<T>(null, cultureInfo);
                        }
                        break;
                }
            }
            else
            {
                if (typeof(T) == typeof(string))
                {
                    return ChangeType<T>(Convert.ToString(value, cultureInfo), cultureInfo);
                }
            }

            if (toType.IsGenericType &&
                toType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                toType = Nullable.GetUnderlyingType(toType);
            }

            try
            {
                if (toType is IConvertible || (toType.IsValueType && !toType.IsEnum))
                {
                    return (T)Convert.ChangeType(value, toType, cultureInfo);
                }
            }
            catch (InvalidCastException)
            {
                //swallow as we have one more attempt left to convert
            }
            catch (FormatException)
            {
                //swallow as we have one more attempt left to convert
            }

            var converter = TypeDescriptor.GetConverter(toType);
            if (converter != null && converter.CanConvertFrom(value.GetType()))
            {
                return (T)converter.ConvertFrom(null, cultureInfo, value);
            }

            return (T)value;
        }

        public static object ChangeTypeWithType(this object value, Type targetType, CultureInfo cultureInfo)
        {
            if (cultureInfo == null) throw new ArgumentNullException("cultureInfo");

            if (value == null)
            {
                if (targetType.IsValueType)
                {
                    return Activator.CreateInstance(targetType);
                }

                return null;
            }

            if (value.GetType() == targetType)
            {
                return value;
            }

            if (value is string)
            {
                var strValue = (string)value;
                if (targetType == Int16Type)
                {
                    Int16 parseInt16;
                    if (Int16.TryParse(TrimDecimalPart(strValue, cultureInfo), NumberStyles.Integer, cultureInfo, out parseInt16))
                    {
                        return parseInt16;
                    }
                }
                else if (targetType == Int32Type)
                {
                    Int32 parseInt32;
                    if (Int32.TryParse(TrimDecimalPart(strValue, cultureInfo), NumberStyles.Integer, cultureInfo, out parseInt32))
                    {
                        return parseInt32;
                    }
                }
                else if (targetType == Int64Type)
                {
                    //string with value "123.000" results in error 'Input string was not in a correct format' if directly attempted to convert to Int64
                    Int64 parseInt64;
                    if (Int64.TryParse(TrimDecimalPart(strValue, cultureInfo), NumberStyles.Integer, cultureInfo, out parseInt64))
                    {
                        return parseInt64;
                    }
                }
                else if (targetType == DateTimeType)
                {
                    DateTime parseDateTime;
                    if (DateTime.TryParse(strValue, cultureInfo, DateTimeStyles.None, out parseDateTime))
                    {
                        return parseDateTime;
                    }
                    else
                    {
                        //If the first try parse failed, we need to attempt to parse using all the avaliable dateTime Patterns.
                        if (DateTime.TryParseExact(strValue, cultureInfo.DateTimeFormat.GetAllDateTimePatterns(), cultureInfo, DateTimeStyles.None, out parseDateTime))
                        {
                            return parseDateTime;
                        }
                    }
                }
                else if (targetType == GuidType)
                {
                    Guid parseGuid;
                    if (Guid.TryParse(strValue, out parseGuid))
                    {
                        return parseGuid;
                    }
                }
                else if (targetType == TimeSpanType)
                {
                    TimeSpan parseTimeSpan;
                    if (TimeSpan.TryParse(strValue, cultureInfo, out parseTimeSpan))
                    {
                        return parseTimeSpan;
                    }
                }
                else if (targetType == DateTimeOffsetType)
                {
                    DateTimeOffset parseDateTimeOffset;
                    if (DateTimeOffset.TryParse(strValue, cultureInfo, DateTimeStyles.None, out parseDateTimeOffset))
                    {
                        return parseDateTimeOffset;
                    }
                }
                else if (strValue == string.Empty && targetType != StringType)
                {
                    return ChangeTypeWithType(null, targetType, cultureInfo);
                }
            }
            else if (targetType == StringType)
            {
                return Convert.ToString(value, cultureInfo);
            }

            return ChangeTypeWithCulture(value, targetType, cultureInfo);
        }

        public static bool IsNullOrEmptyString(this object value)
        {
            if (value == null || value.Equals(string.Empty))
            {
                return true;
            }

            return false;
        }

        private static object ChangeTypeWithCulture(object value, Type targetType, CultureInfo cultureInfo)
        {
            if (targetType.IsGenericType &&
                targetType.GetGenericTypeDefinition() == NullableType)
            {
                targetType = Nullable.GetUnderlyingType(targetType);
            }

            try
            {
                var ic = value as IConvertible;
                if (ic != null)
                {
                    return ic.ToType(targetType, cultureInfo);
                }

                if (targetType.IsValueType && !targetType.IsEnum)
                {
                    return Convert.ChangeType(value, targetType, cultureInfo);
                }
            }
            catch (InvalidCastException)
            {
                //swallow as we have one more attempt left to convert
            }
            catch (FormatException)
            {
                //swallow as we have one more attempt left to convert
            }

            var converter = TypeDescriptor.GetConverter(targetType);
            if (converter != null && converter.CanConvertFrom(value.GetType()))
            {
                return converter.ConvertFrom(null, cultureInfo, value);
            }

            return value;
        }

        /// <summary>
        /// Trims the decimal part.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="cultureInfo">The culture information.</param>
        /// <returns></returns>
        private static string TrimDecimalPart(this string value, CultureInfo cultureInfo)
        {
            if (cultureInfo == null) cultureInfo = CultureInfo.CurrentCulture;

            var index = value.IndexOf(cultureInfo.NumberFormat.NumberDecimalSeparator);

            if (index == 0) return cultureInfo.NumberFormat.NativeDigits[0];
            else if (index < 0) return value;
            else return value.Substring(0, index);
        }
    }
}