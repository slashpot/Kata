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
            if (TitleIsEqualToTail(str))  
                return ToTitleCase(str + str.Substring(1));
          
            return "The " + ToTitleCase(str);
        }

        private static bool TitleIsEqualToTail(string str)
        {
            return ToUpperCase(str[0]) == ToUpperCase(str[str.Length - 1]);
        }

        private static string ToTitleCase(string str)
        {
            return ToUpperCase(str[0]) + str.Substring(1);
        }

        private static char ToUpperCase(char input)
        {
            return char.ToUpper(input);
        }
    }
}
