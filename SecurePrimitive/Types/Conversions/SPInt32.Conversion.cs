// This file is auto generatored. Don't modify it.
using System;

namespace SecurePrimitive
{
	public partial struct SPInt32
	{
		#region SPInt32 <-> SPSByte
		
		public static explicit operator SPInt32(SPSByte value)
		{
			return new SPInt32( (int)value.Value );
		}

		public static explicit operator SPSByte(SPInt32 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		#endregion

		#region SPInt32 <-> sbyte
		
		public static explicit operator SPInt32(sbyte value)
		{
			return new SPInt32( (int)value );
		}

		public static explicit operator sbyte(SPInt32 value)
		{
			return (sbyte)value.Value;
		}

		#endregion

		#region SPInt32 <-> SPByte
		
		public static explicit operator SPInt32(SPByte value)
		{
			return new SPInt32( (int)value.Value );
		}

		public static explicit operator SPByte(SPInt32 value)
		{
			return new SPByte( (byte)value.Value );
		}

		#endregion

		#region SPInt32 <-> byte
		
		public static explicit operator SPInt32(byte value)
		{
			return new SPInt32( (int)value );
		}

		public static explicit operator byte(SPInt32 value)
		{
			return (byte)value.Value;
		}

		#endregion

		#region SPInt32 <-> SPInt16
		
		public static explicit operator SPInt32(SPInt16 value)
		{
			return new SPInt32( (int)value.Value );
		}

		public static explicit operator SPInt16(SPInt32 value)
		{
			return new SPInt16( (short)value.Value );
		}

		#endregion

		#region SPInt32 <-> short
		
		public static explicit operator SPInt32(short value)
		{
			return new SPInt32( (int)value );
		}

		public static explicit operator short(SPInt32 value)
		{
			return (short)value.Value;
		}

		#endregion

		#region SPInt32 <-> SPUInt16
		
		public static explicit operator SPInt32(SPUInt16 value)
		{
			return new SPInt32( (int)value.Value );
		}

		public static explicit operator SPUInt16(SPInt32 value)
		{
			return new SPUInt16( (ushort)value.Value );
		}

		#endregion

		#region SPInt32 <-> ushort
		
		public static explicit operator SPInt32(ushort value)
		{
			return new SPInt32( (int)value );
		}

		public static explicit operator ushort(SPInt32 value)
		{
			return (ushort)value.Value;
		}

		#endregion

		#region SPInt32 <-> int
		
		public static implicit operator SPInt32(int value)
		{
			return new SPInt32( value );
		}

		public static implicit operator int(SPInt32 value)
		{
			return value.Value;
		}

		#endregion

		#region SPInt32 <-> SPUInt32
		
		public static explicit operator SPInt32(SPUInt32 value)
		{
			return new SPInt32( (int)value.Value );
		}

		public static explicit operator SPUInt32(SPInt32 value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		#endregion

		#region SPInt32 <-> uint
		
		public static explicit operator SPInt32(uint value)
		{
			return new SPInt32( (int)value );
		}

		public static explicit operator uint(SPInt32 value)
		{
			return (uint)value.Value;
		}

		#endregion

		#region SPInt32 <-> SPInt64
		
		public static explicit operator SPInt32(SPInt64 value)
		{
			return new SPInt32( (int)value.Value );
		}

		public static explicit operator SPInt64(SPInt32 value)
		{
			return new SPInt64( (long)value.Value );
		}

		#endregion

		#region SPInt32 <-> long
		
		public static explicit operator SPInt32(long value)
		{
			return new SPInt32( (int)value );
		}

		public static explicit operator long(SPInt32 value)
		{
			return (long)value.Value;
		}

		#endregion

		#region SPInt32 <-> SPUInt64
		
		public static explicit operator SPInt32(SPUInt64 value)
		{
			return new SPInt32( (int)value.Value );
		}

		public static explicit operator SPUInt64(SPInt32 value)
		{
			return new SPUInt64( (ulong)value.Value );
		}

		#endregion

		#region SPInt32 <-> ulong
		
		public static explicit operator SPInt32(ulong value)
		{
			return new SPInt32( (int)value );
		}

		public static explicit operator ulong(SPInt32 value)
		{
			return (ulong)value.Value;
		}

		#endregion
	}
}
