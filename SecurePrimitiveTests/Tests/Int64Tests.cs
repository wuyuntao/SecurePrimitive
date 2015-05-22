using NUnit.Framework;
using SecurePrimitive;
using System;

namespace SecurePrimitive.Tests
{
	public class Int64Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var longVal = (long)random.Next();
			var spInt64Val = new SPInt64( longVal );

			Assert.AreEqual( longVal, spInt64Val.Value );

			longVal = (long)random.Next();
			spInt64Val.Value = longVal;

			Assert.AreEqual( longVal, spInt64Val.Value );

			longVal = 0;
			spInt64Val = new SPInt64();

			Assert.AreEqual( longVal, spInt64Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var longVal1 = (long)random.Next();
			var longVal2 = (long)random.Next();

			var spInt64Val1 = new SPInt64( longVal1 );
			var spInt64Val2 = new SPInt64( longVal2 );

			Assert.AreEqual( longVal1.CompareTo( longVal2 ), spInt64Val1.CompareTo( spInt64Val2 ) );
			Assert.AreEqual( spInt64Val1.CompareTo( longVal2 ), spInt64Val1.CompareTo( spInt64Val2 ) );
		}
	}
}