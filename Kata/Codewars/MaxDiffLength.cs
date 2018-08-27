using System;
using System.Linq;

namespace Codewars
{
    public class MaxDiffLength
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (IsOneInputEmpty(a1, a2))
            {
                return -1;
            }
            var firstMax = a1.Select(x => x.Length).Max();
            var firstMin = a1.Select(x => x.Length).Min();
            var secondMax = a2.Select(x => x.Length).Max();
            var secondMin = a2.Select(x => x.Length).Min();
            return Math.Max(firstMax-secondMin,secondMax-firstMin);
        }

        private static bool IsOneInputEmpty(string[] a1, string[] a2)
        {
            return a1.Length==0||a2.Length==0;
        }
    }
}