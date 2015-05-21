// This file is auto generatored. Don't modify it.
using System;

namespace SecurePrimitive.Types
{
	public partial struct SPInt64
	{
		#region SPInt64 <-> SPSByte
		
		public static explicit operator SPInt64(SPSByte value)
		{
			return new SPInt64( (long)value.Value );
		}

		public static explicit operator SPSByte(SPInt64 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		#endregion

		#region SPInt64 <-> sbyte
		
		public static explicit operator SPInt64(sbyte value)
		{
			return new SPInt64( (long)value );
		}

		public static explicit operator sbyte(SPInt64 value)
		{
			return (sbyte)value.Value;
		}

		#endregion

		#region SPInt64 <-> SPByte
		
		public static explicit operator SPInt64(SPByte value)
		{
			return new SPInt64( (long)value.Value );
		}

		public static explicit operator SPByte(SPInt64 value)
		{
			return new SPByte( (byte)value.Value );
		}

		#endregion

		#region SPInt64 <-> byte
		
		public static explicit operator SPInt64(byte value)
		{
			return new SPInt64( (long)value );
		}

		public static explicit operator byte(SPInt64 value)
		{
			return (byte)value.Value;
		}

		#endregion

		#region SPInt64 <-> SPInt16
		
		public static explicit operator SPInt64(SPInt16 value)
		{
			return new SPInt64( (long)value.Value );
		}

		public static explicit operator SPInt16(SPInt64 value)
		{
			return new SPInt16( (short)value.Value );
		}

		#endregion

		#region SPInt64 <-> short
		
		public static explicit operator SPInt64(short value)
		{
			return new SPInt64( (long)value );
		}

		public static explicit operator short(SPInt64 value)
		{
			return (short)value.Value;
		}

		#endregion

		#region SPInt64 <-> SPUInt16
		
		public static explicit operator SPInt64(SPUInt16 value)
		{
			return new SPInt64( (long)value.Value );
		}

		public static explicit operator SPUInt16(SPInt64 value)
		{
			return new SPUInt16( (ushort)value.Value );
		}

		#endregion

		#region SPInt64 <-> ushort
		
		public static explicit operator SPInt64(ushort value)
		{
			return new SPInt64( (long)value );
		}

		public static explicit operator ushort(SPInt64 value)
		{
			return (ushort)value.Value;
		}

		#endregion

		#region SPInt64 <-> SPInt32
		
		public static explicit operator SPInt64(SPInt32 value)
		{
			return new SPInt64( (long)value.Value );
		}

		public static explicit operator SPInt32(SPInt64 value)
		{
			return new SPInt32( (int)value.Value );
		}

		#endregion

		#region SPInt64 <-> int
		
		public static explicit operator SPInt64(int value)
		{
			return new SPInt64( (long)value );
		}

		public static explicit operator int(SPInt64 value)
		{
			return (int)value.Value;
		}

		#endregion

		#region SPInt64 <-> SPUInt32
		
		public static explicit operator SPInt64(SPUInt32 value)
		{
			return new SPInt64( (long)value.Value );
		}

		public static explicit operator SPUInt32(SPInt64 value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		#endregion

		#region SPInt64 <-> uint
		
		public static explicit operator SPInt64(uint value)
		{
			return new SPInt64( (long)value );
		}

		public static explicit operator uint(SPInt64 value)
		{
			return (uint)value.Value;
		}

		#endregion

		#region SPInt64 <-> long
		
		public static implicit operator SPInt64(long value)
		{
			return new SPInt64( value );
		}

		public static implicit operator long(SPInt64 value)
		{
			return value.Value;
		}

		#endregion

		#region SPInt64 <-> SPUInt64
		
		public static explicit operator SPInt64(SPUInt64 value)
		{
			return new SPInt64( (long)value.Value );
		}

		public static explicit operator SPUInt64(SPInt64 value)
		{
			return new SPUInt64( (ulong)value.Value );
		}

		#endregion

		#region SPInt64 <-> ulong
		
		public static explicit operator SPInt64(ulong value)
		{
			return new SPInt64( (long)value );
		}

		public static explicit operator ulong(SPInt64 value)
		{
			return (ulong)value.Value;
		}

		#endregion
	}
}
