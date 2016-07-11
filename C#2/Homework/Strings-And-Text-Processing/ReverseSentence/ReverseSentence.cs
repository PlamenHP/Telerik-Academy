//  Problem 13. Reverse sentence
//  
//      Write a program that reverses the words in given sentence. without changing punctuations places.
//  
//  Example:
//  input                                   output
//  C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class ReverseSentence
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<string> words = new List<string>();
            List<string> splitters = new List<string>();
            StringBuilder word = new StringBuilder();
            StringBuilder splitter = new StringBuilder();
            bool inWord = false;
            bool inSplitter = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) || (input[i]=='#') || char.IsSymbol(input[i]))
                {
                    if (inSplitter)
                    {
                        inSplitter = false;
                        splitters.Add(splitter.ToString());
                        splitter.Clear();
                    }
                    word.Append(input[i]);
                    inWord = true;
                }
                else
                {
                    if (inWord)
                    {
                        inWord = false;
                        words.Add(word.ToString());
                        word.Clear();
                    }
                    splitter.Append(input[i]);
                    inSplitter = true;
                }
            }

            if (inSplitter)
            {
                inSplitter = false;
                splitters.Add(splitter.ToString());
                splitter.Clear();
            }
            if (inWord)
            {
                inWord = false;
                words.Add(word.ToString());
                word.Clear();
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Count || i < splitters.Count; i++)
            {
                result.Append(words[words.Count-1-i]);
                result.Append(splitters[i]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
