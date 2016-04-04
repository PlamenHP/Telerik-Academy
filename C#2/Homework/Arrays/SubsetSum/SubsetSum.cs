//  Problem 16.* Subset with sum S
//  
//      We are given an array of integers and a number S.
//      Write a program to find if there exists a subset of the elements of the array that has a sum S.
//  
//  Example:
//  input array 	            S   	result
//  2, 1, 2, 4, 3, 5, 2, 6   	14 	    yes

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SubsetSum
    {
        static void Main()
        {
            Console.WriteLine("Problem 16.* Subset with sum S\n");
            Console.WriteLine("\nEnter a sequence in the format: 2, 1, 2, 4, 3, 5, 2, 6");
            List<int> data = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            Console.Write("\nEnter a number for the sum S= ");
            int sum = int.Parse(Console.ReadLine());

            bool subsetExists = false;
            for (int i = 0; (i < data.Count) || (!subsetExists); i++)
            {
                foreach (var combination in Combination.Combinations(data, i))
                {
                    if (subsetExists) break;
                    int subSum = 0;
                    foreach (var number in combination.Take(i))
                    {
                        subSum += number;
                    }
                    if (subSum == sum)
                    {
                        Console.WriteLine("\n'yes'\n");
                        Console.WriteLine("Subset with sum 'S' was found: {0}",string.Join(", ", combination.Take(i)));
                        subsetExists = true;
                        break;                        
                    }
                }
            }

            if (!subsetExists) Console.WriteLine("No subset with sum 'S' was found");
        }
    }
}
