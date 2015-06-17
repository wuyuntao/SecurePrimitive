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
    public class Int32Tests
    {
        private Random random = new Random();

        [Test]
        public void TestEquatable()
        {
            var intVal = (int)random.Next();
            var spInt32Val = new SPInt32(intVal);

            Assert.AreEqual(intVal, spInt32Val.Value);

            intVal = (int)random.Next();
            spInt32Val = (SPInt32)intVal;

            Assert.AreEqual(intVal, spInt32Val.Value);

            intVal = 0;
            spInt32Val = new SPInt32();

            Assert.AreEqual(intVal, spInt32Val.Value);
        }

        [Test]
        public void TestComparable()
        {
            var intVal1 = (int)random.Next();
            var intVal2 = (int)random.Next();

            var spInt32Val1 = new SPInt32(intVal1);
            var spInt32Val2 = new SPInt32(intVal2);

            Assert.AreEqual(intVal1.CompareTo(intVal2), spInt32Val1.CompareTo(spInt32Val2));
            Assert.AreEqual(spInt32Val1.CompareTo(intVal2), spInt32Val1.CompareTo(spInt32Val2));
        }
    }
}