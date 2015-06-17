// This file is auto generatored. Don't modify it.
/*
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

using System;

namespace SecurePrimitive
{
	public partial struct SPUInt64
	{
		#region SPUInt64 <-> SPSByte
		
		public static explicit operator SPUInt64(SPSByte value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		public static explicit operator SPSByte(SPUInt64 value)
		{
			return new SPSByte((sbyte)value.Value);
		}

		#endregion

		#region SPUInt64 <-> sbyte
		
		public static explicit operator SPUInt64(sbyte value)
		{
			return new SPUInt64((ulong)value);
		}

		public static explicit operator sbyte(SPUInt64 value)
		{
			return (sbyte)value.Value;
		}

		#endregion

		#region SPUInt64 <-> SPByte
		
		public static explicit operator SPUInt64(SPByte value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		public static explicit operator SPByte(SPUInt64 value)
		{
			return new SPByte((byte)value.Value);
		}

		#endregion

		#region SPUInt64 <-> byte
		
		public static explicit operator SPUInt64(byte value)
		{
			return new SPUInt64((ulong)value);
		}

		public static explicit operator byte(SPUInt64 value)
		{
			return (byte)value.Value;
		}

		#endregion

		#region SPUInt64 <-> SPInt16
		
		public static explicit operator SPUInt64(SPInt16 value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		public static explicit operator SPInt16(SPUInt64 value)
		{
			return new SPInt16((short)value.Value);
		}

		#endregion

		#region SPUInt64 <-> short
		
		public static explicit operator SPUInt64(short value)
		{
			return new SPUInt64((ulong)value);
		}

		public static explicit operator short(SPUInt64 value)
		{
			return (short)value.Value;
		}

		#endregion

		#region SPUInt64 <-> SPUInt16
		
		public static explicit operator SPUInt64(SPUInt16 value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		public static explicit operator SPUInt16(SPUInt64 value)
		{
			return new SPUInt16((ushort)value.Value);
		}

		#endregion

		#region SPUInt64 <-> ushort
		
		public static explicit operator SPUInt64(ushort value)
		{
			return new SPUInt64((ulong)value);
		}

		public static explicit operator ushort(SPUInt64 value)
		{
			return (ushort)value.Value;
		}

		#endregion

		#region SPUInt64 <-> SPInt32
		
		public static explicit operator SPUInt64(SPInt32 value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		public static explicit operator SPInt32(SPUInt64 value)
		{
			return new SPInt32((int)value.Value);
		}

		#endregion

		#region SPUInt64 <-> int
		
		public static explicit operator SPUInt64(int value)
		{
			return new SPUInt64((ulong)value);
		}

		public static explicit operator int(SPUInt64 value)
		{
			return (int)value.Value;
		}

		#endregion

		#region SPUInt64 <-> SPUInt32
		
		public static explicit operator SPUInt64(SPUInt32 value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		public static explicit operator SPUInt32(SPUInt64 value)
		{
			return new SPUInt32((uint)value.Value);
		}

		#endregion

		#region SPUInt64 <-> uint
		
		public static explicit operator SPUInt64(uint value)
		{
			return new SPUInt64((ulong)value);
		}

		public static explicit operator uint(SPUInt64 value)
		{
			return (uint)value.Value;
		}

		#endregion

		#region SPUInt64 <-> SPInt64
		
		public static explicit operator SPUInt64(SPInt64 value)
		{
			return new SPUInt64((ulong)value.Value);
		}

		public static explicit operator SPInt64(SPUInt64 value)
		{
			return new SPInt64((long)value.Value);
		}

		#endregion

		#region SPUInt64 <-> long
		
		public static explicit operator SPUInt64(long value)
		{
			return new SPUInt64((ulong)value);
		}

		public static explicit operator long(SPUInt64 value)
		{
			return (long)value.Value;
		}

		#endregion

		#region SPUInt64 <-> ulong
		
		public static implicit operator SPUInt64(ulong value)
		{
			return new SPUInt64(value);
		}

		public static implicit operator ulong(SPUInt64 value)
		{
			return value.Value;
		}

		#endregion
	}
}
