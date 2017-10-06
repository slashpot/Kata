using System;
using System.Linq;

namespace Kata
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            var lowerStr = str.ToLower();
            var distinctChars = lowerStr.GroupBy(x => x);
            var duplicateCharsCount = distinctChars.Count(x => x.Count() >= 2);
            return duplicateCharsCount;
        }
    }
}
