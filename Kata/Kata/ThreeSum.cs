using System;
using System.Collections.Generic;

namespace Kata
{
    public class ThreeSum
    {
        public IList<IList<int>> GetThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 3) return result;

            Array.Sort(nums);
            int startPos = 0;

            while (startPos < nums.Length - 1)
            {
                int checkPos = startPos + 1;

                while(checkPos < nums.Length)
                {
                    int first = nums[startPos];
                    int second = nums[checkPos];
                    int complement = (first + second) * -1;
                    int nextPos = checkPos + 1;

                    while (checkPos < nums.Length - 1 && nums[checkPos] == nums[checkPos + 1])
                        checkPos++;
                    checkPos++;

                    if (Array.BinarySearch(nums, nextPos, nums.Length - nextPos, complement) < 0)
                        continue;
                    
                    result.Add(new List<int> { first, second, complement });
                }

                while (startPos < nums.Length - 1 && nums[startPos] == nums[startPos + 1])
                    startPos++;
                startPos++;
            }
            return result;
        }
    }
}
