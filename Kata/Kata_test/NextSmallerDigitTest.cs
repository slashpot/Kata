using Codewars;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class NextSmallerDigitTest
    {
        private readonly NextSmallerDigit _converter = new NextSmallerDigit();

        [TestCase(1, TestName = "HasOneDigit 1", ExpectedResult = -1)]
        [TestCase(21, TestName = "HasTwoDigits 21", ExpectedResult = 12)]
        [TestCase(907, TestName = "HasThreeDigits 907", ExpectedResult = 790)]
        [TestCase(531, TestName = "HasThreeDigits 531", ExpectedResult = 513)]
        [TestCase(1027, TestName = "Will Have 0 at beginning after change 1027", ExpectedResult = -1)]
        [TestCase(441, TestName = "Has duplicate number 441", ExpectedResult = 414)]
        [TestCase(123456798, TestName = "large number 123456798", ExpectedResult = 123456789)]
        [TestCase(29009, TestName = "Input 29009", ExpectedResult = 20990)]
        public long HasOneDigit(int input)
        {
            return _converter.NextSmaller(input);
        }
    }
}