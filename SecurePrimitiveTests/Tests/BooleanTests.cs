using NUnit.Framework;
using SecurePrimitive.Types;
using System;

namespace SecurePrimitive.Tests
{
	public class BooleanTests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var boolVal = RandomBoolValue;
			var spBooleanVal = new SPBoolean( boolVal );

			Assert.AreEqual( boolVal, spBooleanVal.Value );

			boolVal = RandomBoolValue;
			spBooleanVal.Value = boolVal;

			Assert.AreEqual( boolVal, spBooleanVal.Value );

			boolVal = false;
			spBooleanVal = new SPBoolean();

			Assert.AreEqual( boolVal, spBooleanVal.Value );
		}

		[Test]
		public void TestComparable()
		{
			var byteVal1 = RandomBoolValue;
			var byteVal2 = RandomBoolValue;

			var spBooleanVal1 = new SPBoolean( byteVal1 );
			var spBooleanVal2 = new SPBoolean( byteVal2 );

			Assert.AreEqual( byteVal1.CompareTo( byteVal2 ), spBooleanVal1.CompareTo( spBooleanVal2 ), string.Format( "{0}, {1}, {2}, {3}", byteVal1, byteVal2, spBooleanVal1, spBooleanVal2 ) );
			Assert.AreEqual( spBooleanVal1.CompareTo( byteVal2 ), spBooleanVal1.CompareTo( spBooleanVal2 ) );
		}

		private bool RandomBoolValue
		{
			get { return random.Next( int.MinValue, int.MaxValue ) > 0; }
		}
	}
}