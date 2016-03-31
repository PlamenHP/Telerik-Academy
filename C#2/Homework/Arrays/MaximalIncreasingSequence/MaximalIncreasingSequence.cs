//  Problem 5. Maximal increasing sequence
//  
//      Write a program that finds the maximal increasing sequence in an array.
//  
//  Example:
//  input 	                result
//  3, 2, 3, 4, 2, 2, 4 	2, 3, 4

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            Console.WriteLine("Problem 5. Maximal increasing sequence\n");
            Console.WriteLine("Enter a sequence in the format: 3, 2, 3, 4, 2, 2, 4");
            string input = Console.ReadLine();
            List<int> array = input.Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToList();
            List<int> result = FindMaximalIncreasingSequence(array);

            Print((result.Count > 1) ? (string.Join(", ", result)) : "no sequential element");
        }

        private static List<int> FindMaximalIncreasingSequence(List<int> array)
        {
            List<int> max = new List<int>() { 0 };
            List<int> current = new List<int>() { 0 };

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i]  == 1 + current[current.Count-1])
                {
                    current.Add(array[i]);
                }
                else
                {
                    current.Clear();
                    current.Add(array[i]);
                }

                if (current.Count > max.Count)
                {
                    max = new List<int>(current);
                }
            }

            return max;
        }

        private static void Print(string result)
        {
            Console.WriteLine(result);
        }
    }
}
