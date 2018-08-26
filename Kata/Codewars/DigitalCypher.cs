using System.Collections.Generic;

namespace Codewars
{
    public class DigitalCypher
    {
        public static int[] Encode(string str, int n)
        {
            var nums = InitialResult(str);
            Calculate(str, n, nums);
            return nums;
        }

        private static int[] InitialResult(string str)
        {
            return new int[str.Length];
        }

        private static void Calculate(string str, int n, IList<int> nums)
        {
            for (var i = 0; i < str.Length; i++)
            {
                nums[i] = GetNumOfAlphabet(str[i]) + GetKeyValue(i, n.ToString());
            }
        }

        private static int GetNumOfAlphabet(char digit)
        {
            return digit - 96;
        }

        private static int GetKeyValue(int index, string key)
        {
            var keyIndex = index % key.Length;
            return GetNumOfChar(key[keyIndex]);
        }

        private static int GetNumOfChar(char digit)
        {
            return digit - 48;
        }
    }
}