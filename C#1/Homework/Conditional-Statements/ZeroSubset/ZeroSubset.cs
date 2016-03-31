//  Problem 12.* Zero Subset
//  
//      We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//      Assume that repeating the same subset several times is not a problem.
//  
//  Examples:
//  numbers 	    result
//  3 -2 1 1 8 	    -2 + 1 + 1 = 0
//  	
//  3 1 -7 35 22 	no zero subset
//  	
//  1 3 -4 -2 -1 	1 + -1 = 0
//              	1 + 3 + -4 = 0
//              	3 + -2 + -1 = 0
//  	
//  1 1 1 -1 -1 	1 + -1 = 0
//  	            1 + 1 + -1 + -1 = 0
//  	
//  0 0 0 0 0   	0 + 0 + 0 + 0 + 0 = 0

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ZeroSubset
    {
        static void Main()
        {
            List<int> set = new List<int>();
            List<int> subset = new List<int>();
            List<List<int>> subsets = new List<List<int>>();
            Console.WriteLine("Zero Subset\n");
            Console.WriteLine("Enter 5 integer numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter number: ");
                set.Add(int.Parse(Console.ReadLine()));
            }

            FindSubSets(subsets, subset, set, 0);
            Print(subsets);
        }

        private static void FindSubSets(List<List<int>> subsets, List<int> subset, List<int> set, int index)
        {
            if (index == set.Count)
            {
                if (subset.Sum() == 0 && subset.Count != 0 && !subsets.Contains(set))
                {
                    subsets.Add(new List<int>(subset));
                }
            }
            else
            {
                FindSubSets(subsets, new List<int>(subset), set, index + 1);
                subset.Add(set[index]);
                FindSubSets(subsets, new List<int>(subset), set, index + 1);
            }
        }

        private static void Print(List<List<int>> subsets)
        {
            Console.WriteLine();
            if (subsets.Count == 0)
            {
                Console.WriteLine("no zero subset");
            }
            else
            {
                List<string> results = new List<string>();
                foreach (var subset in subsets)
                {
                    string result = string.Empty;
                    bool first = true;
                    foreach (var digit in subset)
                    {
                        if (first)
                        {
                            result += String.Format("{0}", digit);
                            first = false;
                        }
                        else
                        {
                            result += String.Format(" + {0}", digit);
                        }
                    }
                    result += String.Format(" = 0");
                    if (!results.Contains(result)) results.Add(result);
                }
                Console.WriteLine(String.Join("\n", results));
            }
        }
    }
}
