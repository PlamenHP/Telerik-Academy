//  Problem 19.* Permutations of set
//  
//      Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//  
//  Example:
//  N        result
//  3 	    {1, 2, 3}
//          {1, 3, 2}
//          {2, 1, 3}
//          {2, 3, 1}
//          {3, 1, 2}
//          {3, 2, 1}

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PermutationsOfSet
    {
        static void Main()
        {
            Console.WriteLine("Problem 19.* Permutations of set \n");
            Console.Write("Enter a number N= ");
            int n = int.Parse(Console.ReadLine());


            Queue<int> data = new Queue<int>(Enumerable.Range(1, n));
            PrintPermutations(data, n);
        }

        private static void PrintPermutations(Queue<int> data, int selectionsToMake)
        {
            int counter = 0;
            int[] result = new int[selectionsToMake];

            foreach (var item in data.ToList())
            {
                result[counter] = item;
                data.Dequeue();
                PickNextItem(data, result, selectionsToMake, counter + 1);
                data.Enqueue(item);
            }
        }

        private static void PickNextItem(Queue<int> data, int[] result, int selectionsToMake, int counter)
        {
            if (counter < selectionsToMake)
            {
                foreach (var item in data.ToList())
                {
                    result[counter] = item;
                    data.Dequeue();
                    PickNextItem(data, result, selectionsToMake, counter + 1);
                    data.Enqueue(item);
                }
            }
            else
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", result));
            }
        }
    }
}
