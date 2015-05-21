// This file is auto generatored. Don't modify it.
using System;

namespace SecurePrimitive.Types
{
	public partial struct SPSByte
	{
		#region SPSByte <-> sbyte
		
		public static implicit operator SPSByte(sbyte value)
		{
			return new SPSByte( value );
		}

		public static implicit operator sbyte(SPSByte value)
		{
			return value.Value;
		}

		#endregion

		#region SPSByte <-> SPByte
		
		public static explicit operator SPSByte(SPByte value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		public static explicit operator SPByte(SPSByte value)
		{
			return new SPByte( (byte)value.Value );
		}

		#endregion

		#region SPSByte <-> byte
		
		public static explicit operator SPSByte(byte value)
		{
			return new SPSByte( (sbyte)value );
		}

		public static explicit operator byte(SPSByte value)
		{
			return (byte)value.Value;
		}

		#endregion

		#region SPSByte <-> SPInt16
		
		public static explicit operator SPSByte(SPInt16 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		public static explicit operator SPInt16(SPSByte value)
		{
			return new SPInt16( (short)value.Value );
		}

		#endregion

		#region SPSByte <-> short
		
		public static explicit operator SPSByte(short value)
		{
			return new SPSByte( (sbyte)value );
		}

		public static explicit operator short(SPSByte value)
		{
			return (short)value.Value;
		}

		#endregion

		#region SPSByte <-> SPUInt16
		
		public static explicit operator SPSByte(SPUInt16 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		public static explicit operator SPUInt16(SPSByte value)
		{
			return new SPUInt16( (ushort)value.Value );
		}

		#endregion

		#region SPSByte <-> ushort
		
		public static explicit operator SPSByte(ushort value)
		{
			return new SPSByte( (sbyte)value );
		}

		public static explicit operator ushort(SPSByte value)
		{
			return (ushort)value.Value;
		}

		#endregion

		#region SPSByte <-> SPInt32
		
		public static explicit operator SPSByte(SPInt32 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		public static explicit operator SPInt32(SPSByte value)
		{
			return new SPInt32( (int)value.Value );
		}

		#endregion

		#region SPSByte <-> int
		
		public static explicit operator SPSByte(int value)
		{
			return new SPSByte( (sbyte)value );
		}

		public static explicit operator int(SPSByte value)
		{
			return (int)value.Value;
		}

		#endregion

		#region SPSByte <-> SPUInt32
		
		public static explicit operator SPSByte(SPUInt32 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		public static explicit operator SPUInt32(SPSByte value)
		{
			return new SPUInt32( (uint)value.Value );
		}

		#endregion

		#region SPSByte <-> uint
		
		public static explicit operator SPSByte(uint value)
		{
			return new SPSByte( (sbyte)value );
		}

		public static explicit operator uint(SPSByte value)
		{
			return (uint)value.Value;
		}

		#endregion

		#region SPSByte <-> SPInt64
		
		public static explicit operator SPSByte(SPInt64 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		public static explicit operator SPInt64(SPSByte value)
		{
			return new SPInt64( (long)value.Value );
		}

		#endregion

		#region SPSByte <-> long
		
		public static explicit operator SPSByte(long value)
		{
			return new SPSByte( (sbyte)value );
		}

		public static explicit operator long(SPSByte value)
		{
			return (long)value.Value;
		}

		#endregion

		#region SPSByte <-> SPUInt64
		
		public static explicit operator SPSByte(SPUInt64 value)
		{
			return new SPSByte( (sbyte)value.Value );
		}

		public static explicit operator SPUInt64(SPSByte value)
		{
			return new SPUInt64( (ulong)value.Value );
		}

		#endregion

		#region SPSByte <-> ulong
		
		public static explicit operator SPSByte(ulong value)
		{
			return new SPSByte( (sbyte)value );
		}

		public static explicit operator ulong(SPSByte value)
		{
			return (ulong)value.Value;
		}

		#endregion
	}
}
