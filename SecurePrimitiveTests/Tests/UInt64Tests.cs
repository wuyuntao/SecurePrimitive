using NUnit.Framework;
using SecurePrimitive.Types;
using System;

namespace SecurePrimitive.Tests
{
	public class UInt64Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var ulongVal = (ulong)random.Next();
			var snUInt64Val = new SPUInt64( ulongVal );

			Assert.AreEqual( ulongVal, snUInt64Val.Value );

			ulongVal = (ulong)random.Next();
			snUInt64Val.Value = ulongVal;

			Assert.AreEqual( ulongVal, snUInt64Val.Value );

			ulongVal = 0;
			snUInt64Val = new SPUInt64();

			Assert.AreEqual( ulongVal, snUInt64Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var ulongVal1 = (ulong)random.Next();
			var ulongVal2 = (ulong)random.Next();

			var snUInt64Val1 = new SPUInt64( ulongVal1 );
			var snUInt64Val2 = new SPUInt64( ulongVal2 );

			Assert.AreEqual( ulongVal1.CompareTo( ulongVal2 ), snUInt64Val1.CompareTo( snUInt64Val2 ) );
			Assert.AreEqual( snUInt64Val1.CompareTo( ulongVal2 ), snUInt64Val1.CompareTo( snUInt64Val2 ) );
		}
	}
}