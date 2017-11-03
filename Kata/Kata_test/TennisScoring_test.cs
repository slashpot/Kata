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
            var tennisScoring = new TennisGame();
            Assert.AreEqual("Love All", tennisScoring.GetStatue());
        }

        [TestCase(1, 0, "Fifteen Love")]
        [TestCase(0, 1, "Love Fifteen")]
        public void GetStatus_Point_Are_Not_Equal_And_Not_Deuce(int ericPoint, int joeyPoint, string expectedStatus)
        {
            var tennisScoring = new TennisGameForTest();
            tennisScoring.SetPlayersPoint(ericPoint, joeyPoint);
            Assert.AreEqual(expectedStatus, tennisScoring.GetStatue());
        }

        [TestCase(0, 0, "Love All")]
        [TestCase(1, 1, "Fifteen All")]
        public void GetStatus_Point_Equal_Except_Deuce(int ericPoint, int joeyPoint, string expectedStatus)
        {
            var tennisScoring = new TennisGameForTest();
            tennisScoring.SetPlayersPoint(ericPoint, joeyPoint);
            Assert.AreEqual(expectedStatus, tennisScoring.GetStatue()); ;
        }

        [Test]
        public void GetStatus_ReturnDeuce()
        {
            var tennisScoring = new TennisGameForTest();
            tennisScoring.SetPlayersPoint(3, 3);
            Assert.AreEqual("Deuce", tennisScoring.GetStatue()); ;
        }

        [TestCase(4,0,"Eric Wins")]
        [TestCase(0,4,"Joey Wins")]
        [TestCase(4,2,"Eric Wins")]
        [TestCase(2,4,"Joey Wins")]
        public void GetStatus_Player_Win_No_Advantage_ReturnPlayerWin(int ericPoint, int joeyPoint, string expectedStatus)
        {
            var tennisScoring = new TennisGameForTest();
            tennisScoring.SetPlayersPoint(ericPoint, joeyPoint);
            Assert.AreEqual(expectedStatus, tennisScoring.GetStatue()); ;
        }
    }

}
