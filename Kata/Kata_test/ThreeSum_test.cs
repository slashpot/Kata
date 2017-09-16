using System.Collections.Generic;
using NUnit.Framework;
using Kata;

namespace Kata_test
{
    [TestFixture]
    public class ThreeSum_test
    {
        [Test]
        public void TestCase1()
        {
            ThreeSum threeSum = new ThreeSum();
            int[] nums = new int[6] { -1, 0, 1, 2, -1, -4 };

            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int> {-1, -1, 2 },
                new List<int> {-1, 0, 1 }
            };
            IList<IList<int>> actual = threeSum.GetThreeSum(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase2()
        {
            ThreeSum threeSum = new ThreeSum();
            int[] nums = new int[2] { 0, 0 };

            IList<IList<int>> expected = new List<IList<int>>();
            IList<IList<int>> actual = threeSum.GetThreeSum(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase3()
        {
            ThreeSum threeSum = new ThreeSum();
            int[] nums = new int[6] {3, 0, -2, -1, 1, 2};

            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int> { -2, -1, 3 },
                new List<int> { -2, 0, 2 },
                new List<int> { -1, 0, 1}
            };
            IList<IList<int>> actual = threeSum.GetThreeSum(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase4()
        {
            ThreeSum threeSum = new ThreeSum();
            int[] nums = new int[3] { 0, 0, 0 };

            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int> { 0, 0, 0 },
            };
            IList<IList<int>> actual = threeSum.GetThreeSum(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase5()
        {
            ThreeSum threeSum = new ThreeSum();
            int[] nums = new int[3] { 0, 1, 1 };

            IList<IList<int>> expected = new List<IList<int>>();
            IList<IList<int>> actual = threeSum.GetThreeSum(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase6()
        {
            ThreeSum threeSum = new ThreeSum();
            int[] nums = new int[15] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };

            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int> { -4, -2, 6},
                new List<int> { -4, 0, 4},
                new List<int> { -4, 1, 3},
                new List<int> { -4, 2, 2},
                new List<int> { -2, -2, 4},
                new List<int> { -2, 0, 2},
            };

            IList<IList<int>> actual = threeSum.GetThreeSum(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
