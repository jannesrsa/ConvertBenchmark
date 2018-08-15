using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBenchmark
{
    /// <summary>
    /// ParameterBuffer
    /// </summary>
    public class ParameterBuffer
    {
        private readonly TypeCode _typeCode;
        private object _object;
        private Storage _value;

        private ParameterBuffer(TypeCode typeCode)
        {
            _typeCode = typeCode;
        }

        public static ParameterBuffer Create<T>(T value)
        {
            var typeCode = Type.GetTypeCode(typeof(T));

            var parameterBuffer = new ParameterBuffer(typeCode);

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    parameterBuffer._value = new Storage { _boolean = Convert.ToBoolean(value) };
                    return parameterBuffer;

                case TypeCode.Char:
                    parameterBuffer._value = new Storage { _char = Convert.ToChar(value) };
                    return parameterBuffer;

                case TypeCode.SByte:
                    parameterBuffer._value = new Storage { _sbyte = Convert.ToSByte(value) };
                    return parameterBuffer;

                case TypeCode.Byte:
                    parameterBuffer._value = new Storage { _byte = Convert.ToByte(value) };
                    return parameterBuffer;

                case TypeCode.Int16:
                    parameterBuffer._value = new Storage { _int16 = Convert.ToInt16(value) };
                    return parameterBuffer;

                case TypeCode.UInt16:
                    parameterBuffer._value = new Storage { _uint16 = Convert.ToUInt16(value) };
                    return parameterBuffer;

                case TypeCode.Int32:
                    parameterBuffer._value = new Storage { _int32 = Convert.ToInt32(value) };
                    return parameterBuffer;

                case TypeCode.UInt32:
                    parameterBuffer._value = new Storage { _uint32 = Convert.ToUInt32(value) };
                    return parameterBuffer;

                case TypeCode.Int64:
                    parameterBuffer._value = new Storage { _int64 = Convert.ToInt64(value) };
                    return parameterBuffer;

                case TypeCode.UInt64:
                    parameterBuffer._value = new Storage { _uint64 = Convert.ToUInt64(value) };
                    return parameterBuffer;

                case TypeCode.Single:
                    parameterBuffer._value = new Storage { _single = Convert.ToSingle(value) };
                    return parameterBuffer;

                case TypeCode.Double:
                    parameterBuffer._value = new Storage { _double = Convert.ToDouble(value) };
                    return parameterBuffer;

                case TypeCode.Decimal:
                    parameterBuffer._value = new Storage { _decimal = Convert.ToDecimal(value) };
                    return parameterBuffer;

                case TypeCode.String:
                    //parameterBuffer._value = new Storage { _string = Convert.ToString(value) };
                    //return parameterBuffer;

                case TypeCode.Object:
                case TypeCode.DBNull:
                case TypeCode.Empty:
                default:
                    parameterBuffer._object = value;
                    return parameterBuffer;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct Storage
        {
            [FieldOffset(0)] internal Boolean _boolean;
            [FieldOffset(0)] internal Char _char;
            [FieldOffset(0)] internal SByte _sbyte;
            [FieldOffset(0)] internal Byte _byte;
            [FieldOffset(0)] internal Int16 _int16;
            [FieldOffset(0)] internal UInt16 _uint16;
            [FieldOffset(0)] internal Int32 _int32;
            [FieldOffset(0)] internal UInt32 _uint32;
            [FieldOffset(0)] internal Int64 _int64;
            [FieldOffset(0)] internal UInt64 _uint64;
            [FieldOffset(0)] internal Single _single;
            [FieldOffset(0)] internal Double _double;
            [FieldOffset(0)] internal Decimal _decimal;
            //[FieldOffset(0)] internal String _string;
        }
    }
}
