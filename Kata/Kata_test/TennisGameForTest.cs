using Kata;

namespace Kata_test
{
    internal class TennisGameForTest : TennisGame
    {
        public void SetPlayersPoint(int ericPoint, int joeyPoint)
        {
            for (var i = 0; i < ericPoint; i++)
            {
                Eric.AddScore();
            }

            for (var i = 0; i < joeyPoint; i++)
            {
                Joey.AddScore();
            }
        }
    }
}