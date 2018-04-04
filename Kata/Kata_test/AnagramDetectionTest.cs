using Codewars;
using NUnit.Framework;

namespace Kata_test
{
    /// <summary>
    /// Summary description for AnagramDetectionTest
    /// </summary>
    [TestFixture]
    public class AnagramDetectionTest
    {
        [TestCase("foefet", "toffee", ExpectedResult = true)]
        [TestCase("Buckethead", "DeathCubeK", ExpectedResult = true)]
        [TestCase("Twoo", "Woot", ExpectedResult = true)]
        [TestCase("apple", "pale", ExpectedResult = false)]
        public bool FixedTest(string test, string original)
        {
            return AnagramDetection.IsAnagram(test, original);
        }
    }
}