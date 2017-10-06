using NUnit.Framework;
using Kata;

namespace Kata_test
{
    /// <summary>
    /// Summary description for DeadAnts_test
    /// </summary>
    [TestFixture]
    public class CountingDuplicates_test
    {
        [TestCase(0,"")]
        [TestCase(0, "abcde")]
        [TestCase(2, "aabbcde")]
        [TestCase(2, "aabBcde")]
        [TestCase(1, "Indivisibility")]
        [TestCase(2, "Indivisibilities")]
        public void TestCountingDuplicates(int excepted, string inputString)
        {
            var actual = CountingDuplicates.DuplicateCount(inputString);
            Assert.AreEqual(excepted, actual);
        }
    }
}
