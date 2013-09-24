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
            string filePath = "D:\\Downloads\\lorem_ipsum.txt";

            StreamReader fileToAnalyze = new StreamReader( filePath );

            string fullText = fileToAnalyze.ReadToEnd();

            System.Console.WriteLine("This document contains {0} words", WordCounter.countResult(fullText) );

            //System.Console.Write( fullText );


            System.Console.Read();

        }
    }
}
