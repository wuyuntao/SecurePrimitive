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
    public class Int16Tests
    {
        private Random random = new Random();

        [Test]
        public void TestEquatable()
        {
            var shortVal = (short)random.Next();
            var spInt16Val = new SPInt16(shortVal);

            Assert.AreEqual(shortVal, spInt16Val.Value);

            shortVal = (short)random.Next();
            spInt16Val = (SPInt16)shortVal;

            Assert.AreEqual(shortVal, spInt16Val.Value);

            shortVal = 0;
            spInt16Val = new SPInt16();

            Assert.AreEqual(shortVal, spInt16Val.Value);
        }

        [Test]
        public void TestComparable()
        {
            var shortVal1 = (short)random.Next();
            var shortVal2 = (short)random.Next();

            var spInt16Val1 = new SPInt16(shortVal1);
            var spInt16Val2 = new SPInt16(shortVal2);

            Assert.AreEqual(shortVal1.CompareTo(shortVal2), spInt16Val1.CompareTo(spInt16Val2));
            Assert.AreEqual(spInt16Val1.CompareTo(shortVal2), spInt16Val1.CompareTo(spInt16Val2));
        }
    }
}