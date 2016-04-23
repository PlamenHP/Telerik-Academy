//  Problem 5. Sort by string length
//  
//      You are given an array of strings. Write a method that sorts the array by the length of its elements(the number of characters composing them).
//  

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortByStringLength
    {
        static void Main()
        {
            Console.WriteLine("Problem 5. Sort by string length\n");
            Console.Write("Enter the lenght of the array: ");
            int arraylenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string elements of the array:");

            List<string> array = new List<string>(arraylenght);

            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("element[{0}]=", i);
                array.Add(Console.ReadLine());
            }

            foreach (string s in SortByLength(array))
            {
                Console.WriteLine(s);
            }
        }

        static IEnumerable<string> SortByLength(IEnumerable<string> e)
        {
            // Use LINQ to sort the array received and return a copy.
            var sorted = from s in e
                         orderby s.Length ascending
                         select s;
            return sorted;
        }
    }
}
