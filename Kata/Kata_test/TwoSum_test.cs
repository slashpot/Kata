using NUnit.Framework;
using Kata;

namespace Kata_test
{
    [TestFixture]
    public class TwoSum_test
    {
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { -3, 4, 3, 90 }, 0, new[] { 0, 2 })]
        public void TestMethod1(int[] nums, int target, int[] expected)
        {
            int[] actual = TwoSum.GetTwoSum(nums, target);
            Assert.AreEqual(expected, actual);
        }
    }
}
