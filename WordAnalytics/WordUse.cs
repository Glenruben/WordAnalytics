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
        public static Array MostUsed(string s)
        {

            MatchCollection collection = Regex.Matches(s.ToLower(), @"[\S]+"); /* 
                                                                                * collection of words in text, made into lowercase
                                                                                * and stripped of non-character symbols. 
                                                                                * TODO:return two dimentional array with [uniqueWord,count] 
                                                                                * and SORT BY COUNT
                                                                                */

            List<string> textArray = new List<string>();

            foreach (Match i in collection)
            {
                textArray.Add(i.ToString());
            }

            //List<String> result = new List<string>;
            string[] result;
            try
            {

                result = textArray.GroupBy(x => x)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToArray();
                    
            }
            catch (Exception e)
            {
                
                throw;
            }
            return result;


        }


    }
}
