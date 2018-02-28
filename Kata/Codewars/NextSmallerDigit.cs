using System;
using System.Text;

namespace Codewars
{
    //http://www.codewars.com/kata/next-smaller-number-with-the-same-digits/train/csharp

    public class NextSmallerDigit
    {
        public long NextSmaller(long n)
        {
            long nextSmallerDigit = -1;
            if (HasOneDigit(n)) return nextSmallerDigit;

            var input = new StringBuilder(n.ToString());
            SwapDigits(ref input);
            SaveIfHeadIsNot0(input, ref nextSmallerDigit);
            return nextSmallerDigit;
        }

        private void SwapDigits(ref StringBuilder input)
        {
            var isSwaped = SwapNumIfHasSmallerValue(input);
            if (!isSwaped)
            {
                SwapFirstDigitWithNextSmallerNum(ref input);
            }
        }

        private void SaveIfHeadIsNot0(StringBuilder input, ref long nextSmallerDigit)
        {
            if (input[0] != '0')
            {
                nextSmallerDigit = Convert.ToInt64(input.ToString());
            }
        }

        private bool SwapNumIfHasSmallerValue(StringBuilder input)
        {
            var checkedIndex = input.Length - 1;
            var isSwaped = false;

            while (checkedIndex > 1)
            {
                if (input[checkedIndex] < input[checkedIndex - 1])
                {
                    Swap(input, checkedIndex, checkedIndex - 1);
                    isSwaped = true;
                    break;
                }
                checkedIndex--;
            }
            return isSwaped;
        }

        private void SwapFirstDigitWithNextSmallerNum(ref StringBuilder input)
        {
            var restNums = GetSubstringArray(input);

            Array.Sort(restNums);
            Array.Reverse(restNums);

            input = new StringBuilder(input[0] + string.Join("", restNums));
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[0])
                {
                    Swap(input, i, 0);
                    break;
                }
            }
        }

        private char[] GetSubstringArray(StringBuilder input)
        {
            return input.ToString().Substring(1).ToCharArray();
        }

        private void Swap(StringBuilder newInput, int i, int j)
        {
            var temp = newInput[i];
            newInput[i] = newInput[j];
            newInput[j] = temp;
        }

        private bool HasOneDigit(long input)
        {
            return input.ToString().Length == 1;
        }
    }
}