using System;
using System.Collections;
using System.Text;

namespace Codewars
{
    public class NextSmallerDigit
    {
        public long NextSmaller(long n)
        {
            if (HasOneDigit(n)) return -1;

            var input = new StringBuilder(n.ToString());
            var isSwaped = SwapNumIfHasSmallerValue(input);
            if (!isSwaped)
            {
                SwapFirstDigitWithNextSmallerNum(ref input);
            }
            return Convert.ToInt64(input.ToString());
        }

        private bool SwapNumIfHasSmallerValue(StringBuilder input)
        {
            var checkedIndex = input.Length - 1;
            var isSwaped = false;

            while (checkedIndex > 1)
            {
                if (input[checkedIndex] < input[checkedIndex - 1])
                {
                    SwapDigit(input, checkedIndex, checkedIndex - 1);
                    isSwaped = true;
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
                    SwapDigit(input, i, 0);
                    break;
                }
            }
        }

        private char[] GetSubstringArray(StringBuilder input)
        {
            return input.ToString().Substring(1).ToCharArray();
        }

        private void SwapDigit(StringBuilder newInput, int i, int j)
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