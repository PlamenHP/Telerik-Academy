//  Problem 6. Sum integers
//  
//      You are given a sequence of positive integer values written into a string, 
//      separated by spaces.
//      Write a function that reads these values from given string 
//      and calculates their sum.
//  
//  Example:
//  input               output
//  "43 68 9 23 318" 	461

namespace Namespace
{
    using System;
    using System.Linq;
    class SumIntegers
    {
        static void Main()
        {
            string givenSequence = Console.ReadLine();

            int result = CalculateSum(givenSequence);
            Console.WriteLine(result);
        }

        private static int CalculateSum(string data)
        {
            var arr = data.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                                .Select(x=>Int32.Parse(x))
                                .ToList();
            int result = arr.Sum();
            return result;
        }
    }
}
