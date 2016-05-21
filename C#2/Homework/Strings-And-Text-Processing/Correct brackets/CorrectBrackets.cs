
// Problem 3. Correct brackets
// 
//     Write a program to check if in a given expression the brackets are put correctly.
// 
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CorrectBrackets
    {
        static void Main()
        {
            string expression = Console.ReadLine();

            try
            {
                Console.WriteLine(CheckBrackets(expression));
            }
            catch (FormatException x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private static string CheckBrackets(string expression)
        {
            string result = "";
            int leftBracketsCount = 0;
            int rightBracketsCount = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBracketsCount++;
                }
                else if (expression[i] == ')')
                {
                    rightBracketsCount++;
                }

                if (i == expression.Length - 1)
                {
                    if (leftBracketsCount != rightBracketsCount)
                    {
                        throw new FormatException("Incorrect brackets");
                    }
                    else
                    {
                        result = "Correct brackets";
                    }
                }
            }
            return result;
        }
    }
}
