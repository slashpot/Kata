using System.Collections.Generic;

namespace Kata
{
    public class TennisScoring
    {
        private int eric = 0;
        private int _joey = 0;

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        public string GetStatue()
        {
            if (eric == _joey)
            {
                return _scoreLookUp[eric] + " All";
            }
            else
            {
                return _scoreLookUp[eric] + " " + _scoreLookUp[_joey];
            }
        }

        public void EricGetPoint()
        {
            eric++;
        }

        public void JoeyGetPoint()
        {
            _joey++;
        }
    }
}