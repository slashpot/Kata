using System.Collections.Generic;

namespace Kata
{
    public class ScoreLookup
    {
        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        public string GetScore(int score)
        {
            return _scoreLookUp[score];
        }
    }
}