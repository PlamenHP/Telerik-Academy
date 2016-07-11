//  Problem 23. Series of letters
//  
//      Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//  
//  Example:
//  input output
//  aaaaabbbbbcdddeeeedssaa abcdedsa

namespace Namespace
{
    using System;
    using System.Text;
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder result = Replace(input);
            Console.WriteLine(result);
        }

        private static StringBuilder Replace(string input)
        {
            char currentChar = input[0];
            StringBuilder result = new StringBuilder();
            result.Append(currentChar);

            int length = input.Length;
            for (int i = 1; i < length; i++)
            {
                if (input[i] != currentChar)
                {
                    currentChar = input[i];
                    result.Append(currentChar);
                }
            }
            return result;
        }
    }
}
