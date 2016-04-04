//  Problem 17.* Subset K with sum S
//  
//      Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//      Find in the array a subset of K elements that have sum S or indicate about its absence.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SubsetKWithSum
    {
        static void Main()
        {
            Console.WriteLine("Problem 17.* Subset K with sum S\n");
            Console.Write("\nEnter the number of elements in the array N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the number of elements in the subset K = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("\nEnter a number for the sum S= ");
            int sum = int.Parse(Console.ReadLine());
            List<int> data = new List<int>();
            Console.WriteLine("\nEnter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}]=", i);
                data.Add(int.Parse(Console.ReadLine()));
            }
            bool subsetExists = false;

            foreach (var combination in Combination.Combinations(data, k))
            {
                if (subsetExists) 
                    break;
                int subSum = 0;

                foreach (var number in combination.Take(k))
                {
                    subSum += number;
                }

                if (subSum == sum)
                {
                    Console.WriteLine("\n'yes'\n");
                    Console.WriteLine("Subset K={0} with sum S={1} was found: {2}", k, sum, string.Join(", ", combination.Take(k)));
                    subsetExists = true;
                    break;
                }
            }

            if (!subsetExists) Console.WriteLine("No subset with sum 'S' was found");
        }
    }
}
