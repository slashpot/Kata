using System.Collections.Generic;

namespace Kata
{
    public class TennisGame
    {
        protected readonly TennisScore Eric = new TennisScore();
        protected readonly TennisScore Joey = new TennisScore();

        private enum ScoreStatus
        {
            Love = 1,
            Fifteen,
            Thirty,
            Forty
        }

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        public string GetStatue()
        {
            if (IsDeuce())
            {
                return "Deuce";
            }
            else
            {
                if (IsEqualNotDeuce())
                {
                    return SetEqualNotDeuceStatue();
                }
                else
                {
                    if (Eric.Score == 4)
                    {
                        return "Eric Wins";
                    }
                    else if (Joey.Score == 4)
                    {
                        return "Joey Wins";
                    }
                    else
                    {
                        return SetNormalStatus();
                    }
                }
            }
        }

        private string SetNormalStatus()
        {
            return _scoreLookUp[Eric.Score] + " " + _scoreLookUp[Joey.Score];
        }

        private string SetEqualNotDeuceStatue()
        {
            return _scoreLookUp[Eric.Score] + " All";
        }

        private bool IsEqualNotDeuce()
        {
            return Eric.Score == Joey.Score;
        }

        private bool IsDeuce()
        {
            return Eric.Score == 3 && Joey.Score == 3;
        }
    }
}