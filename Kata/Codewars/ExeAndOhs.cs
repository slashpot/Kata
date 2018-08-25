using System.Linq;

namespace Codewars
{
    internal class ExeAndOhs
    {
        public static bool XO(string input)
        {
            var xNum = CountNum(input, 'x');
            var oNum = CountNum(input, 'o');
            return xNum == oNum;
        }

        private static int CountNum(string input, char target)
        {
            return input.Count(x => x == target || x == char.ToUpper(target));
        }
    }
}