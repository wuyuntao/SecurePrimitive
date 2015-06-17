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
    public class UInt32Tests
    {
        private Random random = new Random();

        [Test]
        public void TestEquatable()
        {
            var uintVal = (uint)random.Next();
            var snUInt32Val = new SPUInt32(uintVal);

            Assert.AreEqual(uintVal, snUInt32Val.Value);

            uintVal = (uint)random.Next();
            snUInt32Val = (SPUInt32)uintVal;

            Assert.AreEqual(uintVal, snUInt32Val.Value);

            uintVal = 0;
            snUInt32Val = new SPUInt32();

            Assert.AreEqual(uintVal, snUInt32Val.Value);
        }

        [Test]
        public void TestComparable()
        {
            var uintVal1 = (uint)random.Next();
            var uintVal2 = (uint)random.Next();

            var snUInt32Val1 = new SPUInt32(uintVal1);
            var snUInt32Val2 = new SPUInt32(uintVal2);

            Assert.AreEqual(uintVal1.CompareTo(uintVal2), snUInt32Val1.CompareTo(snUInt32Val2));
            Assert.AreEqual(snUInt32Val1.CompareTo(uintVal2), snUInt32Val1.CompareTo(snUInt32Val2));
        }
    }
}