using Kata;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class StringAverage_test
    {
        [TestCase("four", "zero nine five two")]
        [TestCase("three", "four six two three")]
        [TestCase("three", "one two three four five")]
        [TestCase("four", "five four")]
        [TestCase("zero", "zero zero zero zero zero")]
        [TestCase("two", "one one eight one")]
        public void TestNormalCases(string expect, string input)
        {
            TestAverageString(expect, input);
        }

        [TestCase("n/a", "one vpmibk two seven seven")]
        public void TestNonSenseInput(string expect, string input)
        {
            TestAverageString(expect, input);
        }


        [TestCase("n/a", "")]
        public void TestEmptyInput(string expect, string input)
        {
            TestAverageString(expect, input);
        }
        private static void TestAverageString(string expect, string input)
        {
            var stringAverage = new StringAverage();
            var actual = stringAverage.AverageString(input);
            Assert.AreEqual(expect, actual);
        }
    }
}