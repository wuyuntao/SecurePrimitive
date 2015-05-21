using SecurePrimitive.Encryptors;
using System;

namespace SecurePrimitive.Types
{
	public struct SPInt32 : IComparable, IComparable<int>, IComparable<SPInt32>, IFormattable, IEquatable<int>, IEquatable<SPInt32>, IConvertible
	{
		IEncryptor encryptor;
		int encryptedValue;

		public SPInt32(int value)
		{
			encryptor = SecurePrimitiveConfiguration.GeneratorEncryptor();
			encryptedValue = encryptor.Encrypt( value );
		}

		IEncryptor EnsureEncryptor()
		{
			if( encryptor == null )
				encryptor = SecurePrimitiveConfiguration.GeneratorEncryptor();

			return encryptor;
		}

		public int Value
		{
			get { return EnsureEncryptor().Decrypt( encryptedValue ); }
			set { encryptedValue = EnsureEncryptor().Encrypt( value ); }
		}

		#region IComparable

		public int CompareTo(object obj)
		{
			if( obj is int )
				return CompareTo( (int)obj );

			if( obj is SPInt32 )
				return CompareTo( (SPInt32)obj );

			throw new ArgumentException( "value must be an int or SNInt32" );
		}

		public int CompareTo(int value)
		{
			return Value.CompareTo( value );
		}

		public int CompareTo(SPInt32 value)
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

		public bool Equals(int value)
		{
			return Value.Equals( value );
		}

		public bool Equals(SPInt32 value)
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