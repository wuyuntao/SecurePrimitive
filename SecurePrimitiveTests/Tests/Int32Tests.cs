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