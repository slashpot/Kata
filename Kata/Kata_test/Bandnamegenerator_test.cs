using Kata;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Kata_test
{
    [TestFixture]
    public class Bandnamegenerator_test
    {
        [TestCase("The Knife", "knife")]
        [TestCase("Tartart", "tart")]
        [TestCase("Sandlesandles", "sandles")]
        [TestCase("The Bed", "bed")]
        [TestCase("The Brother-in-law", "brother-in-law")]
        public void BandNameGeneratorCases(string expected, string input)
        {
            Assert.AreEqual(expected, Bandnamegenerator.BandNameGenerator(input));
        }
    }
}
