using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Kata_test
{
    /// <summary>
    /// Summary description for DeadAnts_test
    /// </summary>
    [TestClass]
    public class DeadAnts_test
    {
        [TestMethod]
        public void TestDeadAntsCases()
        {
            Assert.AreEqual(0, DeadAnts.DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, DeadAnts.DeadAntCount(null));
            Assert.AreEqual(2, DeadAnts.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, DeadAnts.DeadAntCount("ant ant .... a nt"));
        }
    }
}
