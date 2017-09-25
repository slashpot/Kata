using System;
using System.Linq;

namespace Kata
{
    public class NextBiggerNumberWithTheSameDigits
    {
        public static long NextBiggerNumber(long n)
        {
            var digits = ConvertInputToArray(n);
            var searchIndex = digits.Length - 1;

            while (searchIndex != 0)
            {
                var previousDigit = digits[searchIndex - 1];

                if (digits[searchIndex] <= previousDigit)
                {
                    searchIndex--;
                }
                else
                {
                    Array.Sort(digits, searchIndex, digits.Length - searchIndex);
                    for (int i = searchIndex; i < digits.Length; i++)
                    {
                        if (digits[i] > previousDigit)
                        {
                            var temp = previousDigit;
                            digits[searchIndex - 1] = digits[i];
                            digits[i] = temp;
                            break;
                        }
                    }

                    return long.Parse(string.Join("", digits));
                }
            }

            return -1;
        }

        private static int[] ConvertInputToArray(long n)
        {
            return n.ToString().Select(t => int.Parse(t.ToString())).ToArray();
        }
    }
}