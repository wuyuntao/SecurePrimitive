using NUnit.Framework;
using SecurePrimitive;
using System;

namespace SecurePrimitive.Tests
{
	public class BooleanTests
	{
        private Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var boolVal = RandomBoolValue;
			var spBooleanVal = new SPBoolean( boolVal );

			Assert.AreEqual( boolVal, spBooleanVal.Value );

			boolVal = RandomBoolValue;
            spBooleanVal = (SPBoolean)boolVal;

			Assert.AreEqual( boolVal, spBooleanVal.Value );

			boolVal = false;
			spBooleanVal = new SPBoolean();

			Assert.AreEqual( boolVal, spBooleanVal.Value );
		}

		[Test]
		public void TestComparable()
		{
			var boolVal1 = RandomBoolValue;
			var boolVal2 = RandomBoolValue;

			var spBooleanVal1 = new SPBoolean( boolVal1 );
			var spBooleanVal2 = new SPBoolean( boolVal2 );

			Assert.AreEqual( boolVal1.CompareTo( boolVal2 ), spBooleanVal1.CompareTo( spBooleanVal2 ), string.Format( "{0}, {1}, {2}, {3}", boolVal1, boolVal2, spBooleanVal1, spBooleanVal2 ) );
			Assert.AreEqual( spBooleanVal1.CompareTo( boolVal2 ), spBooleanVal1.CompareTo( spBooleanVal2 ) );
		}

		[Test]
		public void TestConversion()
		{
			bool byteVal1 = RandomBoolValue;
			bool byteVal2 = (bool)new SPBoolean( byteVal1 );
			SPBoolean spBooleanVal = (SPBoolean)byteVal1;

			Assert.AreEqual( byteVal2, spBooleanVal );
		}

		private bool RandomBoolValue
		{
			get { return random.Next( int.MinValue, int.MaxValue ) > 0; }
		}
	}
}