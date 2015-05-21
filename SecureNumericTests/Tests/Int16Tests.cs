using NUnit.Framework;
using SecureNumeric.Types;
using System;

namespace SecureNumeric.Tests
{
	public class Int16Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var shortVal = (short)random.Next();
			var snInt16Val = new SNInt16( shortVal );

			Assert.AreEqual( shortVal, snInt16Val.Value );

			shortVal = (short)random.Next();
			snInt16Val.Value = shortVal;

			Assert.AreEqual( shortVal, snInt16Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var shortVal1 = (short)random.Next();
			var shortVal2 = (short)random.Next();

			var snInt16Val1 = new SNInt16( shortVal1 );
			var snInt16Val2 = new SNInt16( shortVal2 );

			Assert.AreEqual( shortVal1.CompareTo( shortVal2 ), snInt16Val1.CompareTo( snInt16Val2 ) );
			Assert.AreEqual( snInt16Val1.CompareTo( shortVal2 ), snInt16Val1.CompareTo( snInt16Val2 ) );
		}
	}
}