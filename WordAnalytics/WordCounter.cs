using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordAnalytics
{
    class WordCounter
    {
        string inputText;

        public static int countResult(string s)
        {

        MatchCollection counter = Regex.Matches(s, @"[\S]+");
        return counter.Count;

        }


        //public string Text
        //{
        //    set
        //    {
        //        this.inputText = value;
        //    }
        //}

        //public int Count
        //{
        //    set
        //    {
        //        this.inputText = value;
        //    }
            
        //    get
        //    {
        //        return this.countResult(inputText);
        //    }
        //}
        

        


    }
}
