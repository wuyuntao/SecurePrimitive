using NUnit.Framework;
using SecurePrimitive;
using System;

namespace SecurePrimitive.Tests
{
	public class ByteTests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var byteVal = RandomByteValue;
			var spByteVal = new SPByte( byteVal );

			Assert.AreEqual( byteVal, spByteVal.Value );

			byteVal = RandomByteValue;
			spByteVal.Value = byteVal;

			Assert.AreEqual( byteVal, spByteVal.Value );

			byteVal = 0;
			spByteVal = new SPByte();

			Assert.AreEqual( byteVal, spByteVal.Value );
		}

		[Test]
		public void TestComparable()
		{
			var byteVal1 = RandomByteValue;
			var byteVal2 = RandomByteValue;

			var spByteVal1 = new SPByte( byteVal1 );
			var spByteVal2 = new SPByte( byteVal2 );

			Assert.AreEqual( byteVal1.CompareTo( byteVal2 ), spByteVal1.CompareTo( spByteVal2 ) );
			Assert.AreEqual( spByteVal1.CompareTo( byteVal2 ), spByteVal1.CompareTo( spByteVal2 ) );
		}

		[Test]
		public void TestCalculation()
		{
			var byteVal1 = RandomByteValue;
			var byteVal2 = RandomByteValue;

			var res1 = (byte)( byteVal1 + byteVal2 );
			var res2 = (SPByte)byteVal1 + byteVal2;
			var res3 = byteVal1 + (SPByte)byteVal2;
			var res4 = (SPByte)byteVal1 + (SPByte)byteVal2;

			Assert.AreEqual( res1, res2 );
			Assert.AreEqual( res2, res3 );
			Assert.AreEqual( res3, res4 );
		}

		private byte RandomByteValue
		{
			get { return (byte)random.Next(); }
		}
	}
}