using NUnit.Framework;
using SecurePrimitive.Types;
using System;

namespace SecurePrimitive.Tests
{
	public class ByteTests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var byteVal = (byte)random.Next();
			var spByteVal = new SPByte( byteVal );

			Assert.AreEqual( byteVal, spByteVal.Value );

			byteVal = (byte)random.Next();
			spByteVal.Value = byteVal;

			Assert.AreEqual( byteVal, spByteVal.Value );

			byteVal = 0;
			spByteVal = new SPByte();

			Assert.AreEqual( byteVal, spByteVal.Value );
		}

		[Test]
		public void TestComparable()
		{
			var byteVal1 = (byte)random.Next();
			var byteVal2 = (byte)random.Next();

			var spByteVal1 = new SPByte( byteVal1 );
			var spByteVal2 = new SPByte( byteVal2 );

			Assert.AreEqual( byteVal1.CompareTo( byteVal2 ), spByteVal1.CompareTo( spByteVal2 ) );
			Assert.AreEqual( spByteVal1.CompareTo( byteVal2 ), spByteVal1.CompareTo( spByteVal2 ) );
		}
	}
}