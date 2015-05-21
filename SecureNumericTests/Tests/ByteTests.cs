using NUnit.Framework;
using SecureNumeric.Types;
using System;

namespace SecureNumeric.Tests
{
	public class ByteTests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var byteVal = (byte)random.Next();
			var snByteVal = new SNByte( byteVal );

			Assert.AreEqual( byteVal, snByteVal.Value );

			byteVal = (byte)random.Next();
			snByteVal.Value = byteVal;

			Assert.AreEqual( byteVal, snByteVal.Value );
		}

		[Test]
		public void TestComparable()
		{
			var byteVal1 = (byte)random.Next();
			var byteVal2 = (byte)random.Next();

			var snByteVal1 = new SNByte( byteVal1 );
			var snByteVal2 = new SNByte( byteVal2 );

			Assert.AreEqual( byteVal1.CompareTo( byteVal2 ), snByteVal1.CompareTo( snByteVal2 ) );
			Assert.AreEqual( snByteVal1.CompareTo( byteVal2 ), snByteVal1.CompareTo( snByteVal2 ) );
		}
	}
}