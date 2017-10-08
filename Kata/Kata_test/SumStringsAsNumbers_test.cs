using System;
using Kata;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class SumStringsAsNumbers_test
    {
        [Test]
        public void TestMethod1()
        {
            var sumStringsAsNumbers = new SumStringsAsNumbers();
            Assert.AreEqual("579", sumStringsAsNumbers.sumStrings("123", "456"));
        }
    }
}
