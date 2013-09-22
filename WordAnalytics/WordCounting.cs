using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordAnalytics
{
    class WordCounting
    {
        string inputText;
        int countResult = 0;





        public string Text
        {
            set
            {
                this.inputText = value;
            }
        }

        public int Count
        {
            get
            {
                return this.countResult;
            }
        }
        

        


    }
}
