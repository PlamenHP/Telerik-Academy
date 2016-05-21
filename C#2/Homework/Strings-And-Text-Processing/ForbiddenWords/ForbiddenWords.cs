﻿//  Problem 9. Forbidden words
//  
//      We are given a string containing a list of forbidden words and a text containing some of these words.
//      Write a program that replaces the forbidden words with asterisks.
//  
//  Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//  
//  Forbidden words: PHP, CLR, Microsoft
//  
//  The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ForbiddenWords
    {
        static void Main()
        {
            string[] forbiddenWords = new string[] { "PHP", "CLR", "Microsoft" };
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            foreach (var word in forbiddenWords)
            {
                text = text.Replace(word,new string('*',word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
