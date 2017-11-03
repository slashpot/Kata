using System.Collections.Generic;

namespace Kata
{
    public class TennisGame
    {
        protected readonly TennisScore Eric = new TennisScore();
        protected readonly TennisScore Joey = new TennisScore();

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        public string GetStatue()
        {
            if (IsEqual())
            {
                return SetEqualStatus();
            }
            else
            {
                if (Eric.Score >= 4 || Joey.Score >= 4)
                {
                    int difference = Eric.Score - Joey.Score;
                    switch (difference)
                    {
                        case 2:
                            return "Eric Wins";
                        case 1:
                            return "Eric Advance";
                        case -1:
                            return "Joey Advance";
                        case -2:
                            return "Joey Wins";
                    }
                }

                else
                {
                    return SetNormalStatus();
                }
            }
        }

        private string SetEqualStatus()
        {
            return IsDeuce() ? "Deuce" : _scoreLookUp[Eric.Score] + " All";
        }

        private bool IsEqual()
        {
            return Eric.Score == Joey.Score;
        }

        private string SetNormalStatus()
        {
            return _scoreLookUp[Eric.Score] + " " + _scoreLookUp[Joey.Score];
        }

        private bool IsDeuce()
        {
            return Eric.Score == Joey.Score && Eric.Score >= 3;
        }
    }
}