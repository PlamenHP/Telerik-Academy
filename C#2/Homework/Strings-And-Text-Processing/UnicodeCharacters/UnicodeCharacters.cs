//  Problem 10. Unicode characters
//  
//      Write a program that converts a string to a sequence of C# Unicode character literals.
//      Use format strings.
//  
//  Example:
//  input output
//  Hi! 	\u0048\u0069\u0021

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = "Hi!";

            StringBuilder result = new StringBuilder();
            foreach (var ch in input)
            {
                Console.Write("\\u{0:x4}",(int)ch);
            }
            Console.WriteLine();
        }
    }
}
