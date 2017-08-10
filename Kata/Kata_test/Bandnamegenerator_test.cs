using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Kata_test
{
    [TestClass]
    public class Bandnamegenerator_test
    {
        [TestMethod]
        public void BandNameGeneratorCases()
        {
            Assert.AreEqual("The Knife", Bandnamegenerator.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", Bandnamegenerator.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", Bandnamegenerator.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", Bandnamegenerator.BandNameGenerator("bed"));
            Assert.AreEqual("The Brother-in-law", Bandnamegenerator.BandNameGenerator("brother-in-law"));
        }
    }
}
