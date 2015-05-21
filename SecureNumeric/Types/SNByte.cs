﻿using SecureNumeric.Encryptors;
using System;

namespace SecureNumeric.Types
{
	public struct SNByte : IComparable, IComparable<byte>, IComparable<SNByte>, IFormattable, IEquatable<byte>, IEquatable<SNByte>, IConvertible
	{
		Encryptor encryptor;
		byte encryptedValue;

		public SNByte(byte value)
		{
			encryptor = SecureNumericConfiguration.GeneratorEncryptor();
			encryptedValue = encryptor.Encrypt( value );
		}

		public byte Value
		{
			get { return encryptor.Decrypt( encryptedValue ); }
			set { encryptedValue = encryptor.Encrypt( value ); }
		}

		#region IComparable

		public int CompareTo(object obj)
		{
			if( obj is byte )
				return CompareTo( (byte)obj );

			if( obj is SNByte )
				return CompareTo( (SNByte)obj );

			throw new ArgumentException( "value must be a byte or SNByte" );
		}

		public int CompareTo(byte value)
		{
			return Value.CompareTo( value );
		}

		public int CompareTo(SNByte value)
		{
			return Value.CompareTo( value.Value );
		}

		#endregion

		#region IFormattable

		public override string ToString()
		{
			return Value.ToString();
		}

		public string ToString(string format)
		{
			return Value.ToString( format );
		}

		public string ToString(IFormatProvider provider)
		{
			return Value.ToString( provider );
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return Value.ToString( format, provider );
		}

		#endregion

		#region IEquatable

		public override bool Equals(object obj)
		{
			return Value.Equals( obj );
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public bool Equals(byte value)
		{
			return Value.Equals( value );
		}

		public bool Equals(SNByte value)
		{
			return Value.Equals( value.Value );
		}

		#endregion

		#region IConvertable

		public TypeCode GetTypeCode()
		{
			return Value.GetTypeCode();
		}

		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToType( conversionType, provider );
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToBoolean( provider );
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToSByte( provider );
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToByte( provider );
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToInt16( provider );
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToUInt16( provider );
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToInt32( provider );
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToUInt32( provider );
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToInt64( provider );
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToUInt64( provider );
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToSingle( provider );
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToDouble( provider );
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToDecimal( provider );
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToChar( provider );
		}

		string IConvertible.ToString(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToString( provider );
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return ( (IConvertible)Value ).ToDateTime( provider );
		}

		#endregion
	}
}