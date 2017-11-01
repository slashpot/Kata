using System.Collections.Generic;

namespace Kata
{
    public class TennisScoring
    {
        private int eric = 0;
        private int joey = 0;

        private Dictionary<int, string> scoreLookUp = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        public string GetStatue()
        {
            if (eric == joey)
            {
                return scoreLookUp[eric] + " All";
            }
            else
            {
                return scoreLookUp[eric] + " " + scoreLookUp[joey];
            }
        }

        public void EricGetPoint()
        {
            eric++;
        }

        public void JoeyGetPoint()
        {
            joey++;
        }
    }
}