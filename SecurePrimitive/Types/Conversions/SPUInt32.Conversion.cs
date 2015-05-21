// This file is auto generatored. Don't modify it.
using System;

namespace SecurePrimitive.Types
{
	public partial struct SPUInt32
	{
		#region SPUInt32 <-> SPSByte
		
		public static explicit operator SPUInt32(SPSByte value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		public static explicit operator SPSByte(SPUInt32 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		#endregion

		#region SPUInt32 <-> sbyte
		
		public static explicit operator SPUInt32(sbyte value)
		{
			return new SPUInt32( (uint)value );
		}

		public static explicit operator sbyte(SPUInt32 value)
		{
			return (sbyte)value.Value;
		}

		#endregion

		#region SPUInt32 <-> SPByte
		
		public static explicit operator SPUInt32(SPByte value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		public static explicit operator SPByte(SPUInt32 value)
		{
			return new SPByte( (byte)value.Value );
		}

		#endregion

		#region SPUInt32 <-> byte
		
		public static explicit operator SPUInt32(byte value)
		{
			return new SPUInt32( (uint)value );
		}

		public static explicit operator byte(SPUInt32 value)
		{
			return (byte)value.Value;
		}

		#endregion

		#region SPUInt32 <-> SPInt16
		
		public static explicit operator SPUInt32(SPInt16 value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		public static explicit operator SPInt16(SPUInt32 value)
		{
			return new SPInt16( (short)value.Value );
		}

		#endregion

		#region SPUInt32 <-> short
		
		public static explicit operator SPUInt32(short value)
		{
			return new SPUInt32( (uint)value );
		}

		public static explicit operator short(SPUInt32 value)
		{
			return (short)value.Value;
		}

		#endregion

		#region SPUInt32 <-> SPUInt16
		
		public static explicit operator SPUInt32(SPUInt16 value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		public static explicit operator SPUInt16(SPUInt32 value)
		{
			return new SPUInt16( (ushort)value.Value );
		}

		#endregion

		#region SPUInt32 <-> ushort
		
		public static explicit operator SPUInt32(ushort value)
		{
			return new SPUInt32( (uint)value );
		}

		public static explicit operator ushort(SPUInt32 value)
		{
			return (ushort)value.Value;
		}

		#endregion

		#region SPUInt32 <-> SPInt32
		
		public static explicit operator SPUInt32(SPInt32 value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		public static explicit operator SPInt32(SPUInt32 value)
		{
			return new SPInt32( (int)value.Value );
		}

		#endregion

		#region SPUInt32 <-> int
		
		public static explicit operator SPUInt32(int value)
		{
			return new SPUInt32( (uint)value );
		}

		public static explicit operator int(SPUInt32 value)
		{
			return (int)value.Value;
		}

		#endregion

		#region SPUInt32 <-> uint
		
		public static implicit operator SPUInt32(uint value)
		{
			return new SPUInt32( value );
		}

		public static implicit operator uint(SPUInt32 value)
		{
			return value.Value;
		}

		#endregion

		#region SPUInt32 <-> SPInt64
		
		public static explicit operator SPUInt32(SPInt64 value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		public static explicit operator SPInt64(SPUInt32 value)
		{
			return new SPInt64( (long)value.Value );
		}

		#endregion

		#region SPUInt32 <-> long
		
		public static explicit operator SPUInt32(long value)
		{
			return new SPUInt32( (uint)value );
		}

		public static explicit operator long(SPUInt32 value)
		{
			return (long)value.Value;
		}

		#endregion

		#region SPUInt32 <-> SPUInt64
		
		public static explicit operator SPUInt32(SPUInt64 value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		public static explicit operator SPUInt64(SPUInt32 value)
		{
			return new SPUInt64( (ulong)value.Value );
		}

		#endregion

		#region SPUInt32 <-> ulong
		
		public static explicit operator SPUInt32(ulong value)
		{
			return new SPUInt32( (uint)value );
		}

		public static explicit operator ulong(SPUInt32 value)
		{
			return (ulong)value.Value;
		}

		#endregion
	}
}
