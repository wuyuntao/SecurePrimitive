using NUnit.Framework;
using SecureNumeric.Types;
using System;

namespace SecureNumeric.Tests
{
	public class UInt16Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var ushortVal = (ushort)random.Next();
			var snUInt16Val = new SNUInt16( ushortVal );

			Assert.AreEqual( ushortVal, snUInt16Val.Value );

			ushortVal = (ushort)random.Next();
			snUInt16Val.Value = ushortVal;

			Assert.AreEqual( ushortVal, snUInt16Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var ushortVal1 = (ushort)random.Next();
			var ushortVal2 = (ushort)random.Next();

			var snUInt16Val1 = new SNUInt16( ushortVal1 );
			var snUInt16Val2 = new SNUInt16( ushortVal2 );

			Assert.AreEqual( ushortVal1.CompareTo( ushortVal2 ), snUInt16Val1.CompareTo( snUInt16Val2 ) );
			Assert.AreEqual( snUInt16Val1.CompareTo( ushortVal2 ), snUInt16Val1.CompareTo( snUInt16Val2 ) );
		}
	}
}