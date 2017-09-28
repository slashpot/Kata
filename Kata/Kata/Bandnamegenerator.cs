using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Bandnamegenerator
    {
        public static string BandNameGenerator(string str) 
        {
            if (str[0] == str[str.Length - 1])  
                return ToTitleCase(str + str.Substring(1));
          
            return "The " + ToTitleCase(str);
        }

        private static string ToTitleCase(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
