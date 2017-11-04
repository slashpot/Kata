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
                if (OnePlayerAdvanceOrWin())
                {
                    string player = GetAdvanceOrWinningPlayer();
                    string currentStatus;

                    if (Eric.Score - Joey.Score >= 2)
                    {
                        return player + " Wins";
                    }
                    else if (Eric.Score - Joey.Score == 1)
                    {
                        return "Eric Advance";
                    }
                    else if (Eric.Score - Joey.Score == -1)
                    {
                        return "Joey Advance";
                    }
                    else
                    {
                        return "Joey Wins";
                    }
                }
                else
                {
                    return SetNormalStatus();
                }
            }
        }

        private string GetAdvanceOrWinningPlayer()
        {
            return Eric.Score - Joey.Score > 0 ? "Eric" : "Joey";
        }

        private bool OnePlayerAdvanceOrWin()
        {
            return Eric.Score >= 4 || Joey.Score >= 4;
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