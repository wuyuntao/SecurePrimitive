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
    public class SByteTests
    {
        private Random random = new Random();

        [Test]
        public void TestEquatable()
        {
            var sbyteVal = RandomSByteValue;
            var spSByteVal = new SPSByte(sbyteVal);

            Assert.AreEqual(sbyteVal, spSByteVal.Value);

            sbyteVal = RandomSByteValue;
            spSByteVal = (SPSByte)sbyteVal;

            Assert.AreEqual(sbyteVal, spSByteVal.Value);

            sbyteVal = 0;
            spSByteVal = new SPSByte();

            Assert.AreEqual(sbyteVal, spSByteVal.Value);
        }

        [Test]
        public void TestComparable()
        {
            var sbyteVal1 = RandomSByteValue;
            var sbyteVal2 = RandomSByteValue;

            var spSByteVal1 = new SPSByte(sbyteVal1);
            var spSByteVal2 = new SPSByte(sbyteVal2);

            Assert.AreEqual(sbyteVal1.CompareTo(sbyteVal2), spSByteVal1.CompareTo(spSByteVal2));
            Assert.AreEqual(spSByteVal1.CompareTo(sbyteVal2), spSByteVal1.CompareTo(spSByteVal2));
        }

        private sbyte RandomSByteValue
        {
            get { return (sbyte)random.Next(sbyte.MinValue, sbyte.MaxValue); }
        }
    }
}