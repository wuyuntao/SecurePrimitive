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
    public class Int64Tests
    {
        private Random random = new Random();

        [Test]
        public void TestEquatable()
        {
            var longVal = (long)random.Next();
            var spInt64Val = new SPInt64(longVal);

            Assert.AreEqual(longVal, spInt64Val.Value);

            longVal = (long)random.Next();
            spInt64Val = (SPInt64)longVal;

            Assert.AreEqual(longVal, spInt64Val.Value);

            longVal = 0;
            spInt64Val = new SPInt64();

            Assert.AreEqual(longVal, spInt64Val.Value);
        }

        [Test]
        public void TestComparable()
        {
            var longVal1 = (long)random.Next();
            var longVal2 = (long)random.Next();

            var spInt64Val1 = new SPInt64(longVal1);
            var spInt64Val2 = new SPInt64(longVal2);

            Assert.AreEqual(longVal1.CompareTo(longVal2), spInt64Val1.CompareTo(spInt64Val2));
            Assert.AreEqual(spInt64Val1.CompareTo(longVal2), spInt64Val1.CompareTo(spInt64Val2));
        }
    }
}