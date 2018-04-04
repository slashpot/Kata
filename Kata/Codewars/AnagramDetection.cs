using System.Linq;

namespace Codewars
{
    public class AnagramDetection
    {
        public static bool IsAnagram(string test, string original)
        {
            var lowerTest = test.ToLower().OrderBy(x => x);
            var lowerOrigional = original.ToLower().OrderBy(x => x);
            return lowerTest.SequenceEqual(lowerOrigional);
        }
    }
}