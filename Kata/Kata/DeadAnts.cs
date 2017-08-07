using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            if (ants == null) return 0;

            ants = ants.Replace("ant", "");
            return calculateMaxParts(ants);
        }

        private static int calculateMaxParts(string ants)
        {
            int heads = ants.Count(a => a == 'a');
            int bodys = ants.Count(a => a == 'n');
            int legs = ants.Count(a => a == 't');

            return Math.Max(heads, Math.Max(bodys, legs));
        }
    }
}
