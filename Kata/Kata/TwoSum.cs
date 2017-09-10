using System.Collections.Generic;

namespace Kata
{
    public class TwoSum
    {
        public static int[] GetTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> records = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                int another = target - current;

                if (records.ContainsKey(another))
                {
                    result[0] = records[another];
                    result[1] = i;
                    break;
                }
                if (!records.ContainsKey(current))
                    records.Add(current, i);
            }
            return result;
        }
    }
}
