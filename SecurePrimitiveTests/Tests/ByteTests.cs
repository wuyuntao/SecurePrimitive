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
    public class ByteTests
    {
        private Random random = new Random();

        [Test]
        public void TestEquatable()
        {
            var byteVal = RandomByteValue;
            var spByteVal = new SPByte(byteVal);

            Assert.AreEqual(byteVal, spByteVal.Value);

            byteVal = RandomByteValue;
            spByteVal = (SPByte)byteVal;

            Assert.AreEqual(byteVal, spByteVal.Value);

            byteVal = 0;
            spByteVal = new SPByte();

            Assert.AreEqual(byteVal, spByteVal.Value);
        }

        [Test]
        public void TestComparable()
        {
            var byteVal1 = RandomByteValue;
            var byteVal2 = RandomByteValue;

            var spByteVal1 = new SPByte(byteVal1);
            var spByteVal2 = new SPByte(byteVal2);

            Assert.AreEqual(byteVal1.CompareTo(byteVal2), spByteVal1.CompareTo(spByteVal2));
            Assert.AreEqual(spByteVal1.CompareTo(byteVal2), spByteVal1.CompareTo(spByteVal2));
        }

        private byte RandomByteValue
        {
            get { return (byte)random.Next(); }
        }
    }
}