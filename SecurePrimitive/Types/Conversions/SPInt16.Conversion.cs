// This file is auto generatored. Don't modify it.
using System;

namespace SecurePrimitive
{
	public partial struct SPInt16
	{
		#region SPInt16 <-> SPSByte
		
		public static explicit operator SPInt16(SPSByte value)
		{
			return new SPInt16((short)value.Value);
		}

		public static explicit operator SPSByte(SPInt16 value)
		{
			return new SPSByte((sbyte)value.Value);
		}

		#endregion

		#region SPInt16 <-> sbyte
		
		public static explicit operator SPInt16(sbyte value)
		{
			return new SPInt16((short)value);
		}

		public static explicit operator sbyte(SPInt16 value)
		{
			return (sbyte)value.Value;
		}

		#endregion

		#region SPInt16 <-> SPByte
		
		public static explicit operator SPInt16(SPByte value)
		{
			return new SPInt16((short)value.Value);
		}

		public static explicit operator SPByte(SPInt16 value)
		{
			return new SPByte((byte)value.Value);
		}

		#endregion

		#region SPInt16 <-> byte
		
		public static explicit operator SPInt16(byte value)
		{
			return new SPInt16((short)value);
		}

		public static explicit operator byte(SPInt16 value)
		{
			return (byte)value.Value;
		}

		#endregion

		#region SPInt16 <-> short
		
		public static implicit operator SPInt16(short value)
		{
			return new SPInt16(value);
		}

		public static implicit operator short(SPInt16 value)
		{
			return value.Value;
		}

		#endregion

		#region SPInt16 <-> SPUInt16
		
		public static explicit operator SPInt16(SPUInt16 value)
		{
			return new SPInt16((short)value.Value);
		}

		public static explicit operator SPUInt16(SPInt16 value)
		{
			return new SPUInt16((ushort)value.Value);
		}

		#endregion

		#region SPInt16 <-> ushort
		
		public static explicit operator SPInt16(ushort value)
		{
			return new SPInt16((short)value);
		}

		public static explicit operator ushort(SPInt16 value)
		{
			return (ushort)value.Value;
		}

		#endregion

		#region SPInt16 <-> SPInt32
		
		public static explicit operator SPInt16(SPInt32 value)
		{
			return new SPInt16((short)value.Value);
		}

		public static explicit operator SPInt32(SPInt16 value)
		{
			return new SPInt32((int)value.Value);
		}

		#endregion

		#region SPInt16 <-> int
		
		public static explicit operator SPInt16(int value)
		{
			return new SPInt16((short)value);
		}

		public static explicit operator int(SPInt16 value)
		{
			return (int)value.Value;
		}

		#endregion

		#region SPInt16 <-> SPUInt32
		
		public static explicit operator SPInt16(SPUInt32 value)
		{
			return new SPInt16((short)value.Value);
		}

		public static explicit operator SPUInt32(SPInt16 value)
		{
			return new SPUInt32((uint)value.Value);
		}

		#endregion

		#region SPInt16 <-> uint
		
		public static explicit operator SPInt16(uint value)
		{
			return new SPInt16((short)value);
		}

		public static explicit operator uint(SPInt16 value)
		{
			return (uint)value.Value;
		}

		#endregion

		#region SPInt16 <-> SPInt64
		
		public static explicit operator SPInt16(SPInt64 value)
		{
			return new SPInt16((short)value.Value);
		}

		public static explicit operator SPInt64(SPInt16 value)
		{
			return new SPInt64((long)value.Value);
		}

		#endregion

		#region SPInt16 <-> long
		
		public static explicit operator SPInt16(long value)
		{
			return new SPInt16((short)value);
		}

		public static explicit operator long(SPInt16 value)
		{
			return (long)value.Value;
		}

		#endregion

		#region SPInt16 <-> SPUInt64
		
		public static explicit operator SPInt16(SPUInt64 value)
		{
			return new SPInt16((short)value.Value);
		}

		public static explicit operator SPUInt64(SPInt16 value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		#endregion

		#region SPInt16 <-> ulong
		
		public static explicit operator SPInt16(ulong value)
		{
			return new SPInt16((short)value);
		}

		public static explicit operator ulong(SPInt16 value)
		{
			return (ulong)value.Value;
		}

		#endregion
	}
}
