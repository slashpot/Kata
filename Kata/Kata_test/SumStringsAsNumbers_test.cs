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
            Assert.AreEqual("579", SumStringsAsNumbers.sumStrings("123", "456"));
        }
    }
}
