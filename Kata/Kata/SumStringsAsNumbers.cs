using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class SumStringsAsNumbers    
    {
        public static string sumStrings(string a, string b)
        {
            long firstNum = Convert.ToInt64(a);
            long secondNum = Convert.ToInt64(b);
            long sum = firstNum + secondNum;
            return sum.ToString();
        }
    }
}
