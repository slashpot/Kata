namespace Tennis
{
    public class TennisGame
    {
        private int _firstPlayer = 0;

        public string GetResult()
        {
            if (_firstPlayer == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerGetPoint()
        {
            _firstPlayer++;
        }
    }
}