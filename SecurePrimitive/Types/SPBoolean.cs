﻿/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2015 Wu Yuntao
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
*/

using SecurePrimitive.Encryptors;
using System;

namespace SecurePrimitive
{
    public struct SPBoolean : IComparable, IComparable<bool>, IComparable<SPBoolean>, IEquatable<bool>, IEquatable<SPBoolean>, IConvertible
    {
        private SPSByte encryptedValue;

        public SPBoolean(bool value)
        {
            encryptedValue = new SPSByte(ConvertToSByte(value));
        }

        private static sbyte ConvertToSByte(bool value)
        {
            return (sbyte)(value ? 1 : -1);
        }

        public bool Value
        {
            get { return encryptedValue.Value > 0; }
        }

        #region IComparable

        public int CompareTo(object obj)
        {
            if (obj is bool)
                return CompareTo((bool)obj);

            if (obj is SPBoolean)
                return CompareTo((SPBoolean)obj);

            throw new ArgumentException("value must be a bool or SNBoolean");
        }

        public int CompareTo(bool value)
        {
            return Value.CompareTo(value);
        }

        public int CompareTo(SPBoolean value)
        {
            return Value.CompareTo(value.Value);
        }

        #endregion

        #region IFormattable

        public override string ToString()
        {
            return Value.ToString();
        }

        public string ToString(IFormatProvider provider)
        {
            return Value.ToString(provider);
        }

        #endregion

        #region IEquatable

        public override bool Equals(object obj)
        {
            return Value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public bool Equals(bool value)
        {
            return Value.Equals(value);
        }

        public bool Equals(SPBoolean value)
        {
            return Value.Equals(value.Value);
        }

        #endregion

        #region IConvertable

        public TypeCode GetTypeCode()
        {
            return Value.GetTypeCode();
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            return ((IConvertible)Value).ToType(conversionType, provider);
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToBoolean(provider);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToSByte(provider);
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToByte(provider);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToInt16(provider);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToUInt16(provider);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToInt32(provider);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToUInt32(provider);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToInt64(provider);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToUInt64(provider);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToSingle(provider);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToDouble(provider);
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToDecimal(provider);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToChar(provider);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToString(provider);
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            return ((IConvertible)Value).ToDateTime(provider);
        }

        #endregion

        #region Type Conversion

        public static explicit operator SPBoolean(bool value)
        {
            return new SPBoolean(value);
        }

        public static explicit operator bool(SPBoolean value)
        {
            return value.Value;
        }

        #endregion
    }
}