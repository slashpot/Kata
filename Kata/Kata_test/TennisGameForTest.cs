using Kata;

namespace Kata_test
{
    internal class TennisGameForTest : TennisGame
    {
        public void SetPlayersPoint(int ericPoint, int joeyPoint)
        {
            Eric.Score = ericPoint;
            Joey.Score = joeyPoint;
        }
    }
}