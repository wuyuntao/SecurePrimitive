// This file is auto generatored. Don't modify it.
using System;

namespace SecurePrimitive
{
	public partial struct SPByte
	{
		#region SPByte <-> SPSByte
		
		public static explicit operator SPByte(SPSByte value)
		{
			return new SPByte((byte)value.Value);
		}

		public static explicit operator SPSByte(SPByte value)
		{
			return new SPSByte((sbyte)value.Value);
		}

		#endregion

		#region SPByte <-> sbyte
		
		public static explicit operator SPByte(sbyte value)
		{
			return new SPByte((byte)value);
		}

		public static explicit operator sbyte(SPByte value)
		{
			return (sbyte)value.Value;
		}

		#endregion

		#region SPByte <-> byte
		
		public static implicit operator SPByte(byte value)
		{
			return new SPByte(value);
		}

		public static implicit operator byte(SPByte value)
		{
			return value.Value;
		}

		#endregion

		#region SPByte <-> SPInt16
		
		public static explicit operator SPByte(SPInt16 value)
		{
			return new SPByte((byte)value.Value);
		}

		public static explicit operator SPInt16(SPByte value)
		{
			return new SPInt16((short)value.Value);
		}

		#endregion

		#region SPByte <-> short
		
		public static explicit operator SPByte(short value)
		{
			return new SPByte((byte)value);
		}

		public static explicit operator short(SPByte value)
		{
			return (short)value.Value;
		}

		#endregion

		#region SPByte <-> SPUInt16
		
		public static explicit operator SPByte(SPUInt16 value)
		{
			return new SPByte((byte)value.Value);
		}

		public static explicit operator SPUInt16(SPByte value)
		{
			return new SPUInt16((ushort)value.Value);
		}

		#endregion

		#region SPByte <-> ushort
		
		public static explicit operator SPByte(ushort value)
		{
			return new SPByte((byte)value);
		}

		public static explicit operator ushort(SPByte value)
		{
			return (ushort)value.Value;
		}

		#endregion

		#region SPByte <-> SPInt32
		
		public static explicit operator SPByte(SPInt32 value)
		{
			return new SPByte((byte)value.Value);
		}

		public static explicit operator SPInt32(SPByte value)
		{
			return new SPInt32((int)value.Value);
		}

		#endregion

		#region SPByte <-> int
		
		public static explicit operator SPByte(int value)
		{
			return new SPByte((byte)value);
		}

		public static explicit operator int(SPByte value)
		{
			return (int)value.Value;
		}

		#endregion

		#region SPByte <-> SPUInt32
		
		public static explicit operator SPByte(SPUInt32 value)
		{
			return new SPByte((byte)value.Value);
		}

		public static explicit operator SPUInt32(SPByte value)
		{
			return new SPUInt32((uint)value.Value);
		}

		#endregion

		#region SPByte <-> uint
		
		public static explicit operator SPByte(uint value)
		{
			return new SPByte((byte)value);
		}

		public static explicit operator uint(SPByte value)
		{
			return (uint)value.Value;
		}

		#endregion

		#region SPByte <-> SPInt64
		
		public static explicit operator SPByte(SPInt64 value)
		{
			return new SPByte((byte)value.Value);
		}

		public static explicit operator SPInt64(SPByte value)
		{
			return new SPInt64((long)value.Value);
		}

		#endregion

		#region SPByte <-> long
		
		public static explicit operator SPByte(long value)
		{
			return new SPByte((byte)value);
		}

		public static explicit operator long(SPByte value)
		{
			return (long)value.Value;
		}

		#endregion

		#region SPByte <-> SPUInt64
		
		public static explicit operator SPByte(SPUInt64 value)
		{
			return new SPByte((byte)value.Value);
		}

		public static explicit operator SPUInt64(SPByte value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		#endregion

		#region SPByte <-> ulong
		
		public static explicit operator SPByte(ulong value)
		{
			return new SPByte((byte)value);
		}

		public static explicit operator ulong(SPByte value)
		{
			return (ulong)value.Value;
		}

		#endregion
	}
}
