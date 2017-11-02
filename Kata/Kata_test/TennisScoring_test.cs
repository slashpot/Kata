using System;
using Kata;
using NUnit.Framework;

namespace Kata_test
{
    [TestFixture]
    public class TennisScoringTest
    {
        [Test]
        public void GetStatus_Beginning_ReturnLoveAll()
        {
            TennisScoring tennisScoring = new TennisScoring();
            Assert.AreEqual("Love All", tennisScoring.GetStatue());
        }

        [TestCase(1, 0, "Fifteen Love")]
        [TestCase(0, 1, "Love Fifteen")]
        public void GetStatus_Point_Are_Not_Equal_And_Not_Deuce(int ericPoint, int joeyPoint, string expectedStatus)
        {
            TennisScoringForTest tennisScoring = new TennisScoringForTest();
            tennisScoring.SetPlayersPoint(ericPoint, joeyPoint);
            Assert.AreEqual(expectedStatus, tennisScoring.GetStatue());
        }

        [TestCase(0, 0, "Love All")]
        [TestCase(1, 1, "Fifteen All")]
        public void GetStatus_Point_Equal_except_deuce(int ericPoint, int joeyPoint, string expectedStatus)
        {
            TennisScoringForTest tennisScoring = new TennisScoringForTest();
            tennisScoring.SetPlayersPoint(ericPoint, joeyPoint);
            Assert.AreEqual(expectedStatus, tennisScoring.GetStatue()); ;
        }
    }

}
