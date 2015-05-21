using NUnit.Framework;
using SecurePrimitive.Types;
using System;

namespace SecurePrimitive.Tests
{
	public class UInt32Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var uintVal = (uint)random.Next();
			var snUInt32Val = new SPUInt32( uintVal );

			Assert.AreEqual( uintVal, snUInt32Val.Value );

			uintVal = (uint)random.Next();
			snUInt32Val.Value = uintVal;

			Assert.AreEqual( uintVal, snUInt32Val.Value );

			uintVal = 0;
			snUInt32Val = new SPUInt32();

			Assert.AreEqual( uintVal, snUInt32Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var uintVal1 = (uint)random.Next();
			var uintVal2 = (uint)random.Next();

			var snUInt32Val1 = new SPUInt32( uintVal1 );
			var snUInt32Val2 = new SPUInt32( uintVal2 );

			Assert.AreEqual( uintVal1.CompareTo( uintVal2 ), snUInt32Val1.CompareTo( snUInt32Val2 ) );
			Assert.AreEqual( snUInt32Val1.CompareTo( uintVal2 ), snUInt32Val1.CompareTo( snUInt32Val2 ) );
		}
	}
}