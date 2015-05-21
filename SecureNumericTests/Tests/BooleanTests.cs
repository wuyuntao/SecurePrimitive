using NUnit.Framework;
using SecureNumeric.Types;
using System;

namespace SecureNumeric.Tests
{
	public class BooleanTests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var boolVal = RandomBoolValue;
			var snBooleanVal = new SNBoolean( boolVal );

			Assert.AreEqual( boolVal, snBooleanVal.Value );

			boolVal = RandomBoolValue;
			snBooleanVal.Value = boolVal;

			Assert.AreEqual( boolVal, snBooleanVal.Value );
		}

		[Test]
		public void TestComparable()
		{
			var byteVal1 = RandomBoolValue;
			var byteVal2 = RandomBoolValue;

			var snBooleanVal1 = RandomBoolValue;
			var snBooleanVal2 = RandomBoolValue;

			Assert.AreEqual( byteVal1.CompareTo( byteVal2 ), snBooleanVal1.CompareTo( snBooleanVal2 ) );
			Assert.AreEqual( snBooleanVal1.CompareTo( byteVal2 ), snBooleanVal1.CompareTo( snBooleanVal2 ) );
		}

		private bool RandomBoolValue
		{
			get { return random.Next( int.MinValue, int.MaxValue ) > 0; }
		}
	}
}