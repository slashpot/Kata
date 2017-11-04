using System;
using System.Collections.Generic;

namespace Kata
{
    public class TennisGame
    {
        protected readonly TennisScore Eric = new TennisScore();
        protected readonly TennisScore Joey = new TennisScore();
        private readonly ScoreLookup _scoreLookup = new ScoreLookup();

        public string GetStatue()
        {
            return IsEqual()
                ? SetEqualStatus()
                : (OnePlayerAdvanceOrWin() ? SetAdvanceOrWinStatus() : SetNormalStatus());
        }

        private string SetAdvanceOrWinStatus()
        {
            var player = GetAdvanceOrWinningPlayer();
            var currentStatus = GetAdvanceOrWinningStatus();
            return player + currentStatus;
        }

        private string GetAdvanceOrWinningStatus()
        {
            var different = Math.Abs(Eric.Score - Joey.Score);
            return different >= 2 ? " Wins" : " Advance";
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
            return IsDeuce() ? "Deuce" : _scoreLookup.GetScore(Eric.Score) + " All";
        }

        private bool IsEqual()
        {
            return Eric.Score == Joey.Score;
        }

        private string SetNormalStatus()
        {
            return _scoreLookup.GetScore(Eric.Score) + " " + _scoreLookup.GetScore(Joey.Score);
        }

        private bool IsDeuce()
        {
            return Eric.Score == Joey.Score && Eric.Score >= 3;
        }
    }
}