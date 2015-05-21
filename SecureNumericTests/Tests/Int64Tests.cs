using NUnit.Framework;
using SecureNumeric.Types;
using System;

namespace SecureNumeric.Tests
{
	public class Int64Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var longVal = (long)random.Next();
			var snInt64Val = new SNInt64( longVal );

			Assert.AreEqual( longVal, snInt64Val.Value );

			longVal = (long)random.Next();
			snInt64Val.Value = longVal;

			Assert.AreEqual( longVal, snInt64Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var longVal1 = (long)random.Next();
			var longVal2 = (long)random.Next();

			var snInt64Val1 = new SNInt64( longVal1 );
			var snInt64Val2 = new SNInt64( longVal2 );

			Assert.AreEqual( longVal1.CompareTo( longVal2 ), snInt64Val1.CompareTo( snInt64Val2 ) );
			Assert.AreEqual( snInt64Val1.CompareTo( longVal2 ), snInt64Val1.CompareTo( snInt64Val2 ) );
		}
	}
}