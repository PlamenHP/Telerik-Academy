//  Problem 21.* Combinations of set
//  
//      Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//  
//  Example:
//  N 	K 	result
//  5 	2 	{1, 2}
//          {1, 3}
//          {1, 4}
//          {1, 5}
//          {2, 3}
//          {2, 4}
//          {2, 5}
//          {3, 4}
//          {3, 5}
//          {4, 5}

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PermutationsOfSet
    {
        static void Main()
        {
            Console.WriteLine("Problem 21.* Combinations of set");
            Console.Write("Enter a number N= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a number K= ");
            int k = int.Parse(Console.ReadLine());

            List<int> data = new List<int>(Enumerable.Range(1, n));
            PrintCombinations(data, k);
        }

        private static void PrintCombinations(List<int> data, int selectionsToMake)
        {
            int selectionsLeft = selectionsToMake;
            int[] result = new int[selectionsToMake];

            foreach (var item in data.ToList())
            {
                result[selectionsToMake - selectionsLeft] = item;
                data.Remove(item);
                PickNextItem(data, result, selectionsToMake, selectionsLeft - 1);
            }
        }

        private static void PickNextItem(List<int> data, int[] result, int selectionsToMake, int selectionsLeft)
        {
            if (selectionsLeft > 0)
            {
                foreach (var item in data)
                {
                    result[selectionsToMake - selectionsLeft] = item;
                    PickNextItem(data, result, selectionsToMake, selectionsLeft - 1);
                }
            }
            else
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", result));
            }
        }
    }
}
