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