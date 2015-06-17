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
    public class UInt16Tests
    {
        private Random random = new Random();

        [Test]
        public void TestEquatable()
        {
            var ushortVal = (ushort)random.Next();
            var snUInt16Val = new SPUInt16(ushortVal);

            Assert.AreEqual(ushortVal, snUInt16Val.Value);

            ushortVal = (ushort)random.Next();
            snUInt16Val = (SPUInt16)ushortVal;

            Assert.AreEqual(ushortVal, snUInt16Val.Value);

            ushortVal = 0;
            snUInt16Val = new SPUInt16();

            Assert.AreEqual(ushortVal, snUInt16Val.Value);
        }

        [Test]
        public void TestComparable()
        {
            var ushortVal1 = (ushort)random.Next();
            var ushortVal2 = (ushort)random.Next();

            var snUInt16Val1 = new SPUInt16(ushortVal1);
            var snUInt16Val2 = new SPUInt16(ushortVal2);

            Assert.AreEqual(ushortVal1.CompareTo(ushortVal2), snUInt16Val1.CompareTo(snUInt16Val2));
            Assert.AreEqual(snUInt16Val1.CompareTo(ushortVal2), snUInt16Val1.CompareTo(snUInt16Val2));
        }
    }
}