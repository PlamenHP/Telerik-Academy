//  Problem 4. Maximal sequence
//  
//      Write a program that finds the maximal sequence of equal elements in an array.
//  
//  Example:
//  input 	                        result
//  2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MaximalSequence
    {
        static void Main()
        {
            Console.WriteLine("Problem 4. Maximal sequence\n");
            Console.WriteLine("Enter a sequence in the format: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1");
            string input = Console.ReadLine();
            List<int> array = input.Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToList();
            List<int> result = FindMaxSequence(array);

            Print((result.Count > 1) ? (string.Join(", ", result)) : "no sequential element");
        }

        private static List<int> FindMaxSequence(List<int> array)
        {
            List<int> max = new List<int>() { 0 };
            List<int> current = new List<int>() { 0 };

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == current[current.Count-1])
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
