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
	public class UInt64Tests
	{
        private Random random = new Random();

		[Test]
		public void TestEquatable()
		{
			var ulongVal = (ulong)random.Next();
			var snUInt64Val = new SPUInt64( ulongVal );

			Assert.AreEqual( ulongVal, snUInt64Val.Value );

			ulongVal = (ulong)random.Next();
			snUInt64Val = (SPUInt64) ulongVal;

			Assert.AreEqual( ulongVal, snUInt64Val.Value );

			ulongVal = 0;
			snUInt64Val = new SPUInt64();

			Assert.AreEqual( ulongVal, snUInt64Val.Value );
		}

		[Test]
		public void TestComparable()
		{
			var ulongVal1 = (ulong)random.Next();
			var ulongVal2 = (ulong)random.Next();

			var snUInt64Val1 = new SPUInt64( ulongVal1 );
			var snUInt64Val2 = new SPUInt64( ulongVal2 );

			Assert.AreEqual( ulongVal1.CompareTo( ulongVal2 ), snUInt64Val1.CompareTo( snUInt64Val2 ) );
			Assert.AreEqual( snUInt64Val1.CompareTo( ulongVal2 ), snUInt64Val1.CompareTo( snUInt64Val2 ) );
		}
	}
}