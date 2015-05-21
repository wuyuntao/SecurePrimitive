using NUnit.Framework;
using SecurePrimitive.Types;
using System;

namespace SecurePrimitive.Tests
{
	public class Int16Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var shortVal = (short)random.Next();
			var spInt16Val = new SPInt16( shortVal );

			Assert.AreEqual( shortVal, spInt16Val.Value );

			shortVal = (short)random.Next();
			spInt16Val.Value = shortVal;

			Assert.AreEqual( shortVal, spInt16Val.Value );

			shortVal = 0;
			spInt16Val = new SPInt16();

			Assert.AreEqual( shortVal, spInt16Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var shortVal1 = (short)random.Next();
			var shortVal2 = (short)random.Next();

			var spInt16Val1 = new SPInt16( shortVal1 );
			var spInt16Val2 = new SPInt16( shortVal2 );

			Assert.AreEqual( shortVal1.CompareTo( shortVal2 ), spInt16Val1.CompareTo( spInt16Val2 ) );
			Assert.AreEqual( spInt16Val1.CompareTo( shortVal2 ), spInt16Val1.CompareTo( spInt16Val2 ) );
		}
	}
}