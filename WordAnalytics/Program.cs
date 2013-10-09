using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

namespace WordAnalytics
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\lorem_ipsum.txt";

            StreamReader fileToAnalyze = new StreamReader( filePath );

            string fullText = fileToAnalyze.ReadToEnd();

            System.Console.WriteLine("This document contains {0} words", Counter.WordCounter(fullText) );

            System.Console.WriteLine("This document contains {0} letters.", Counter.LetterCounter(fullText));

            System.Console.WriteLine( "This document contains {0} letters and symbols excluding whitespace.", Counter.SymbolCounter( fullText ) );

            System.Console.WriteLine( "This document contains {0} letters and symbols including whitespace.", Counter.WhitespaceAndSymbolCounter( fullText ) );

            System.Console.WriteLine("The most used words in this document are {0}, {1} and {2}.", WordUse.MostUsed(fullText).GetValue(0), WordUse.MostUsed(fullText).GetValue(1), WordUse.MostUsed(fullText).GetValue(2));

            System.Console.Read();

        }
    }
}
