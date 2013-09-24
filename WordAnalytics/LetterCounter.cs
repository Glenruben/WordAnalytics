using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordAnalytics
{
    class LetterCounter
    {

        public static int countResult (string s)
        {
            MatchCollection counter = Regex.Matches( s, @"\p{L}" );
            return counter.Count;
        }


    }
}
