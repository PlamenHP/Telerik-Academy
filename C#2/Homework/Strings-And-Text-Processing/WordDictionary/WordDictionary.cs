//  Problem 14. Word dictionary
//  
//      A dictionary is stored as a sequence of text lines containing words and their explanations.
//      Write a program that enters a word and translates it by using the dictionary.
//  
//  Sample dictionary:
//  input output
//  .NET    platform for applications from Microsoft
//  CLR     managed execution environment for .NET
//  namespace hierarchical organization of classes

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class WordDictionary
    {
        private static readonly Dictionary<string, string> Translate = new Dictionary<string, string>
            {
                {".NET" ,"platform for applications from Microsoft"},
                {"CLR" ,"managed execution environment for .NET"},
                {"namespace" ,"hierarchical organization of classes"}
            };

        static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                Console.WriteLine(Translate[input]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
