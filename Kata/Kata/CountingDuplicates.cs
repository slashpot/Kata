using System;

namespace Kata
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            if (str.Contains(" "))
                str = str.Replace(" ", string.Empty);

            int indexOfDuplicate = GetIndexOfDuplicateChar(str);
            if (indexOfDuplicate == -1)
                return 0;

            str = str.Replace(str[indexOfDuplicate].ToString(), string.Empty);
            return DuplicateCount(str) + 1;
        }

        private static int GetIndexOfDuplicateChar(string str)
        {
            int duplicate = -1;

            for (int i = 0; i < str.Length; i++)
                for (int j = i + 1; j < str.Length; j++)
                    if (Char.ToLower(str[i]) == Char.ToLower(str[j]))
                        duplicate = i;

            return duplicate;
        }
    }
}
