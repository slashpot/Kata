using System;

namespace Kata
{
    public class StringAverage
    {
        private string[] _words;
        private int _sum;
        private enum WordTable
        { zero, one, two, three, four, five, six, seven, eight, nine };

        public string AverageString(string input)
        {
            _words = GetSplitWords(input);
            _sum = GetSumOfWords();
            return GetWordBySum();
        }

        private string GetWordBySum()
        {
            return _sum != -1 ? Enum.GetName(typeof(WordTable), (_sum / _words.Length)) : "n/a";
        }

        private int GetSumOfWords()
        {
            var sum = 0;

            foreach (string word in _words)
            {
                var current = GetNumber(word);
                if (current != -1)
                    sum += current;
                else
                    return -1;
            }
            return sum;
        }

        private static string[] GetSplitWords(string input)
        {
            return input.Split(' ');
        }

        private static int GetNumber(string input)
        {
            WordTable table;
            if (Enum.TryParse(input, out table))
                return (int)table;

            return -1;
        }
    }
}