using System;
using System.Linq;

namespace Codewars
{
    //http://www.codewars.com/kata/next-smaller-number-with-the-same-digits/train/csharp

    public class NextSmallerDigit
    {
        public long NextSmaller(long n)
        {
            long nextSmallerDigit = -1;
            var nums = n.ToString().ToCharArray();

            if (HasOneDigit(n) || HasNoSmallerDigits(nums))
                return nextSmallerDigit;

            SwapDigits(ref nums);
            SaveIfHeadIsNot0(ref nums, ref nextSmallerDigit);

            return nextSmallerDigit;
        }

        private bool HasOneDigit(long input)
        {
            return input.ToString().Length == 1;
        }

        private bool HasNoSmallerDigits(char[] nums)
        {
            var sorted = nums.OrderBy(x => x);
            return nums.SequenceEqual(sorted);
        }

        private void SwapDigits(ref char[] nums)
        {
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                ReverseSortFromNextIndex(nums, i);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        Swap(nums, i, j);
                        return;
                    }
                }
            }
        }

        private static void ReverseSortFromNextIndex(char[] nums, int i)
        {
            Array.Sort(nums, i + 1, nums.Length - (i + 1));
            Array.Reverse(nums, i + 1, nums.Length - (i + 1));
        }

        private void Swap(char[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private void SaveIfHeadIsNot0(ref char[] nums, ref long nextSmallerDigit)
        {
            if (nums[0] != '0')
            {
                nextSmallerDigit = Convert.ToInt64(string.Join("", nums));
            }
        }
    }
}