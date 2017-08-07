using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata_test
{
    [TestClass]
    public class StringAverage_test
    {
        [TestMethod]
        public void TestStringAverageCases()
        {
            TestMethod("four", "zero nine five two");
            TestMethod("three", "four six two three");
            TestMethod("three", "one two three four five");
            TestMethod("four", "five four");
            TestMethod("zero", "zero zero zero zero zero");
            TestMethod("two", "one one eight one");
            TestMethod("n/a", "");
            TestMethod("n/a", "one vpmibk two seven seven");
        }

        private void TestMethod(string expect, string input)
        {
            var actual = StringAverage.AverageString(input);
            Assert.AreEqual(expect, actual);
        }
    }
}
