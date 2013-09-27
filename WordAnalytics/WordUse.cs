using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordAnalytics
{
    class WordUse
    {
        public Array mostUsed( string s )
        {
            
            MatchCollection collection = Regex.Matches( s.ToLower(), @"[\S]+"); //collection of words in text, case ignored. TODO: Find unique words and count instances!

            

        }
    }
}
