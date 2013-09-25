using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordAnalytics
{
    class Counter
    {
        string inputText;

        public static int WordCounter(string s)
        {

        MatchCollection counter = Regex.Matches(s, @"[\S]+");
        return counter.Count;

        }

        public static int LetterCounter( string s )
        {
            MatchCollection counter = Regex.Matches( s, @"\p{L}" );
            return counter.Count;
        }

        public static int SymbolCounter( string s )
        {
            MatchCollection counter = Regex.Matches( s, @"\S" );
            return counter.Count;
        }

        public static int WhitespaceAndSymbolCounter( string s )
        {
            MatchCollection counter = Regex.Matches( s, @"\S|\s" );
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
