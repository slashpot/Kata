using Kata;

namespace Kata_test
{
    internal class TennisScoringForTest : TennisScoring
    {
        public void SetPlayersPoint(int ericPoint, int joeyPoint)
        {
            for (int i = 0; i < ericPoint; i++)
            {
                EricGetPoint();
            }

            for (int i = 0; i < joeyPoint; i++)
            {
                JoeyGetPoint();
            }
        }
    }
}