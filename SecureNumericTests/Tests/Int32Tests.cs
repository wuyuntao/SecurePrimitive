using NUnit.Framework;
using SecureNumeric.Types;
using System;

namespace SecureNumeric.Tests
{
	public class Int32Tests
	{
		Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var intVal = (int)random.Next();
			var snInt32Val = new SNInt32( intVal );

			Assert.AreEqual( intVal, snInt32Val.Value );

			intVal = (int)random.Next();
			snInt32Val.Value = intVal;

			Assert.AreEqual( intVal, snInt32Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var intVal1 = (int)random.Next();
			var intVal2 = (int)random.Next();

			var snInt32Val1 = new SNInt32( intVal1 );
			var snInt32Val2 = new SNInt32( intVal2 );

			Assert.AreEqual( intVal1.CompareTo( intVal2 ), snInt32Val1.CompareTo( snInt32Val2 ) );
			Assert.AreEqual( snInt32Val1.CompareTo( intVal2 ), snInt32Val1.CompareTo( snInt32Val2 ) );
		}
	}
}