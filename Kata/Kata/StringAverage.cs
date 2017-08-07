using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class StringAverage
    {
        enum Table { zero, one, two, three, four, five, six, seven, eight, nine };

        static void Main(string[] args)
        {
        }

        public static string AverageString(string input)
        {
            string[] words = input.Split(' ');
            int sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                int current = getNumber(words[i]);

                if (current != -1)
                    sum += current;
                else
                    return "n/a";
            }

            return Enum.GetName(typeof(Table), (sum / words.Length));
        }

        private static int getNumber(string input)
        {
            Table table;

            if (Enum.TryParse(input, out table))
                return (int)table;

            return -1;
        }
    }
}
