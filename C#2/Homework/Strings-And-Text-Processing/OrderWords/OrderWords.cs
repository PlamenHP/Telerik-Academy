//  Problem 24. Order words
//  
//      Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OrderWords
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
