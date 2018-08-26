namespace Codewars
{
    public class DigitalCypher
    {
        public static int[] Encode(string str, int n)
        {
            var nums = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                nums[i] = str[i] - 96 + GetKeyValue(i, n);
            }
            return nums;
        }

        private static int GetKeyValue(int index, int key)
        {
            var keyString = key.ToString();
            var keyIndex = index % keyString.Length;
            return keyString[keyIndex]-48;
        }
    }
}