/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2015 Wu Yuntao
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
*/

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