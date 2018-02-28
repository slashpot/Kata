using Codewars;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class NextSmallerDigitTest
    {
        private readonly NextSmallerDigit _converter = new NextSmallerDigit();

        [TestCase(1, TestName = "HasOneDigit", ExpectedResult = -1)]
        [TestCase(21, TestName = "HasTwoDigits", ExpectedResult = 12)]
        [TestCase(907, TestName = "HasThreeDigits", ExpectedResult = 790)]
        [TestCase(531, TestName = "HasThreeDigits", ExpectedResult = 513)]
        public long HasOneDigit(int input)
        {
            return _converter.NextSmaller(input);
        }
    }
}