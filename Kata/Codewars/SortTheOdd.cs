using System.Collections.Generic;

namespace Codewars
{
    public class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            var indexes= new List<int>();
            var odds=new List<int>();
            GetOddIndexesAndNums(array,indexes,odds);
            odds.Sort();
            SortOdds(array,indexes,odds);
            return array;
        }

        private static void SortOdds(int[] array, List<int> indexes, List<int> odds)
        {
            for (int i = 0; i < indexes.Count; i++)
            {
                array[indexes[i]]=odds[i];
            }
        }


        private static void GetOddIndexesAndNums(int[] array, List<int> indexes, List<int> odds)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    indexes.Add(i);
                    odds.Add(array[i]);
                }
            }
        }
    }
}