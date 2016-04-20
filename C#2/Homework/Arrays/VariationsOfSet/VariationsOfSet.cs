//  Problem 20.* Variations of set
//  
//      Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//  
//  Example:
//  N 	K 	result
//  3 	2 	{1, 1}
//          {1, 2}
//          {1, 3}
//          {2, 1}
//          {2, 2}
//          {2, 3}
//          {3, 1}
//          {3, 2}
//          {3, 3}

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PermutationsOfSet
    {
        static void Main()
        {
            Console.WriteLine("Problem 20.* Variations of set \n");
            Console.Write("Enter a number N= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a number K= ");
            int k = int.Parse(Console.ReadLine());

            List<int> data = new List<int>(Enumerable.Range(1, n));
            PrintVariations(data, k);
        }

        private static void PrintVariations(List<int> data, int selectionsToMake)
        {
            int counter = 0;
            int[] result = new int[selectionsToMake];

            foreach (var item in data)
            {
                result[counter] = item;
                PickNextItem(data, result, selectionsToMake, counter + 1);
            }
        }

        private static void PickNextItem(List<int> data, int[] result, int selectionsToMake, int counter)
        {
            if (counter < selectionsToMake)
            {
                foreach (var item in data)
                {
                    result[counter] = item;
                    PickNextItem(data, result, selectionsToMake, counter + 1);
                }
            }
            else
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", result));
            }
        }
    }
}
