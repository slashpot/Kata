using System;
using Codewars;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class ExeAndOhsTests
    {
        [TestCase("xo", ExpectedResult = true)]
        [TestCase("xxOo", ExpectedResult = true)]
        [TestCase("xxxm", ExpectedResult = false)]
        [TestCase("Oo", ExpectedResult = false)]
        [TestCase("ooom", ExpectedResult = false)]
        public bool Test(string input)
        {
            return ExeAndOhs.XO(input);
        }
    }
}
