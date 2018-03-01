using Kata;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class SumStringsAsNumbers_test
    {
        [SetUp]
        public void SetUp()
        {
            SumStringsAsNumbers.Initialize();
        }

        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "1")]
        [TestCase("1", "2", "3")]
        [TestCase("12", "34", "46")]
        [TestCase("123", "345", "468")]
        public void SumString_InputsAreSameDigitsWithoutCarry(string firstInput, string secondInput, string sum)
        {
            Assert.AreEqual(sum, SumStringsAsNumbers.SumStrings(firstInput, secondInput));
        }

        [TestCase("1", "23", "24")]
        [TestCase("12", "3465", "3477")]
        public void SumString_InputsAreDifferentDigitsWithoutCarry(string firstInput, string secondInput, string sum)
        {
            Assert.AreEqual(sum, SumStringsAsNumbers.SumStrings(firstInput, secondInput));
        }

        [TestCase("548", "345", "893")]
        [TestCase("942", "13795", "14737")]
        public void SumString_WithCarryExceptFirstDigit(string firstInput, string secondInput, string sum)
        {
            Assert.AreEqual(sum, SumStringsAsNumbers.SumStrings(firstInput, secondInput));
        }

        [TestCase("00863", "0841", "1704")]
        public void SumString_With0AtHeadOfInput(string firstInput, string secondInput, string sum)
        {
            Assert.AreEqual(sum, SumStringsAsNumbers.SumStrings(firstInput, secondInput));
        }
    }
}