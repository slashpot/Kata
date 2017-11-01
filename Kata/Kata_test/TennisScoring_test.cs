using System;
using Kata;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class TennisScoring_test
    {
        [Test]
        public void GetStatus_Beginning_ReturnLoveAll()
        {
            TennisScoring tennisScoring = new TennisScoring();
            Assert.AreEqual("Love All", tennisScoring.GetStatue());
        }

        [Test]
        public void GetStatus_Eric1_Joey0_ReturnFifteenLove()
        {
            TennisScoring tennisScoring = new TennisScoring();
            tennisScoring.EricGetPoint();
            Assert.AreEqual("Fifteen Love", tennisScoring.GetStatue());
        }

        [Test]
        public void GetStatus_Eric0_Joey1_ReturnLoveFifteen()
        {
            TennisScoring tennisScoring = new TennisScoring();
            tennisScoring.JoeyGetPoint();
            Assert.AreEqual("Love Fifteen", tennisScoring.GetStatue());
        }

        [Test]
        public void GetStatus_Eric1_Joey1_ReturnFifteenAll()
        {
            TennisScoring tennisScoring = new TennisScoring();
            tennisScoring.JoeyGetPoint();
            tennisScoring.EricGetPoint();
            Assert.AreEqual("Fifteen All", tennisScoring.GetStatue());
        }


    }

}
