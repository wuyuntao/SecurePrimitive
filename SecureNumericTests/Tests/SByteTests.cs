using NUnit.Framework;
using SecureNumeric.Types;
using System;

namespace SecureNumeric.Tests
{
	public class SByteTests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var sbyteVal = (sbyte)random.Next();
			var snSByteVal = new SNSByte( sbyteVal );

			Assert.AreEqual( sbyteVal, snSByteVal.Value );

			sbyteVal = (sbyte)random.Next();
			snSByteVal.Value = sbyteVal;

			Assert.AreEqual( sbyteVal, snSByteVal.Value );
		}

		[Test]
		public void TestComparable()
		{
			var sbyteVal1 = (sbyte)random.Next();
			var sbyteVal2 = (sbyte)random.Next();

			var snSByteVal1 = new SNSByte( sbyteVal1 );
			var snSByteVal2 = new SNSByte( sbyteVal2 );

			Assert.AreEqual( sbyteVal1.CompareTo( sbyteVal2 ), snSByteVal1.CompareTo( snSByteVal2 ) );
			Assert.AreEqual( snSByteVal1.CompareTo( sbyteVal2 ), snSByteVal1.CompareTo( snSByteVal2 ) );
		}
	}
}