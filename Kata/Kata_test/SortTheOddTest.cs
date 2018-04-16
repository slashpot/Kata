using System;
using Codewars;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Kata_test
{
    [TestClass]
    public class SortTheOddTest
    {
        [TestCase(new int[0])]
        public void SortTheOdd_EmptyArray(int[] input)
        {
            var expected=new int[0].ToExpectedObject();
            var actual=SortTheOdd.SortArray(input);
            expected.ShouldEqual(actual);
        }

        [TestCase(new int[]{2,6,8,4})]
        public void SortTheOdd_HasOnlyEvenNum(int[] input)
        {
            var expected=new int[]{2,6,4,8}.ToExpectedObject();
            var actual=SortTheOdd.SortArray(input);
            expected.ShouldEqual(actual);
        }

    }
}
