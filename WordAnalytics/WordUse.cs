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

            List<string> collectionList = new List<string>;

            foreach (Match match in collection)
            {
                collectionList.Add(match);
            }

            string wordString = collection.ToString();

            

            List<String> counter = wordString.GroupBy(x => x)
                                            .Where(g => g.Count() > 1)
                                            .Select(g => g.Key)
                                            .ToList();

        }
    }
}
