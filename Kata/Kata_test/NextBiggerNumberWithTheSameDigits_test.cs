

using Kata;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class NextBiggerNumberWithTheSameDigits_test
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(59884848459853, 59884848483559)]
        public void HasBiggerNumber(long input, long expected)
        {
            Assert.AreEqual(expected, NextBiggerNumberWithTheSameDigits.NextBiggerNumber(input));
        }

        [TestCase(9)]
        [TestCase(111)]
        [TestCase(531)]
        public void HasNoBiggerNumber(long input)
        {
            Assert.AreEqual(-1, NextBiggerNumberWithTheSameDigits.NextBiggerNumber(input));
        }
    }
}
