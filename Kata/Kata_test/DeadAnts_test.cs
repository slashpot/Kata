using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Kata_test
{
    /// <summary>
    /// Summary description for DeadAnts_test
    /// </summary>
    [TestFixture()]
    public class DeadAnts_test
    {
        [TestCase(0, "ant ant ant ant")]
        public void All_Ants_Are_Alive(int expected, string input)
        {
            Assert.AreEqual(2, DeadAnts.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, DeadAnts.DeadAntCount("ant ant .... a nt"));
            TestDeadAntCount(expected, input);
        }

        [TestCase(0, null)]
        public void No_Ants(int expected, string input)
        {
            TestDeadAntCount(expected, input);
        }

        [TestCase(2, "ant anantt aantnt")]
        [TestCase(1, "ant ant .... a nt")]
        public void Has_Dead_Ants(int expected, string input)
        {
            TestDeadAntCount(expected, input);
        }

        private void TestDeadAntCount(int expected, string input)
        {
            Assert.AreEqual(expected, DeadAnts.DeadAntCount(input));
        }
    }
}
