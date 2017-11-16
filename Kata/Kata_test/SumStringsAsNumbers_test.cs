using Kata;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class SumStringsAsNumbers_test
    {
        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "1")]
        [TestCase("1", "2", "3")]
        [TestCase("12", "34", "46")]
        [TestCase("123", "345", "468")]
        public void SumString_InputsAreSameDigitsWithoutCarry_ReturnSum(string firstInput, string secondInput, string sum)
        {
            var sumStringsAsNumbers = new SumStringsAsNumbers();
            Assert.AreEqual(sum, sumStringsAsNumbers.SumStrings(firstInput, secondInput));
        }

        [TestCase("1", "23", "24")]
        public void SumString_InputsAreDifferentDigitsWithoutCarry_ReturnSum(string firstInput, string secondInput, string sum)
        {
            var sumStringsAsNumbers = new SumStringsAsNumbers();
            Assert.AreEqual(sum, sumStringsAsNumbers.SumStrings(firstInput, secondInput));
        }

        //[TestCase("8", "9", "17")]
        //public void SumString_InputsAreSameDigitWithCarry_ReturnSum(string firstInput, string secondInput, string sum)
        //{
        //    var sumStringsAsNumbers = new SumStringsAsNumbers();
        //    Assert.AreEqual(sum, sumStringsAsNumbers.SumStrings(firstInput, secondInput));
        //}
    }
}