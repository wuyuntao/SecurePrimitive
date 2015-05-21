using SecureNumeric.Encryptors;
using System;

namespace SecureNumeric.Types
{
	public struct SNUInt16 : IComparable, IComparable<ushort>, IComparable<SNUInt16>, IFormattable, IEquatable<ushort>, IEquatable<SNUInt16>, IConvertible
	{
		Encryptor encryptor;
		ushort encryptedValue;

		public SNUInt16(ushort value)
		{
			encryptor = SecureNumericConfiguration.GeneratorEncryptor();
			encryptedValue = encryptor.Encrypt( value );
		}

		public ushort Value
		{
			get { return encryptor.Decrypt( encryptedValue ); }
			set { encryptedValue = encryptor.Encrypt( value ); }
		}

		#region IComparable

		public int CompareTo(object obj)
		{
			if( obj is ushort )
				return CompareTo( (ushort)obj );

			if( obj is SNUInt16 )
				return CompareTo( (SNUInt16)obj );

			throw new ArgumentException( "value must be a ushort or SNUInt16" );
		}

		public int CompareTo(ushort value)
		{
			return Value.CompareTo( value );
		}

		public int CompareTo(SNUInt16 value)
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

		public bool Equals(ushort value)
		{
			return Value.Equals( value );
		}

		public bool Equals(SNUInt16 value)
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