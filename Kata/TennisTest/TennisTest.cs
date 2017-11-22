using NUnit.Framework;
using Tennis;

namespace TennisTest
{
    [TestFixture]
    public class TennisTest
    {
        private TennisGame _tennisGame = new TennisGame();

        [SetUp]
        public void Initialize()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [Test]
        public void Fifteen_Love()
        {
            SetFirstPlayerPoint(1);
            ScoreShouldBe("Fifteen Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.GetResult());
        }

        private void SetFirstPlayerPoint(int round)
        {
            for (int i = 0; i < round; i++)
            {
                _tennisGame.FirstPlayerGetPoint();
            }
        }
    }
}