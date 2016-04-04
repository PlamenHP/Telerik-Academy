//  Problem 11. Binary search
//  
//      Write a program that finds the index of given element in a sorted array of integers 
//      by using the Binary search algorithm.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("Problem 11. Binary search\n");
            Console.Write("Enter the first number of the sequence: ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("Enter the last number of the sequence: ");
            int to = int.Parse(Console.ReadLine());
            Console.Write("Enter a number of the sequence to find: ");
            int number = int.Parse(Console.ReadLine());

            List<int> data = Enumerable.Range(from, (to - from) + 1).ToList();

            int result = FindIndexOfNumber(data, number);

            // List<int> result = new List<int>(data, int number);
            if (result!=-1)
            {
                Console.WriteLine("Target {0} was found at index {1}", number, result);
            }
            else
            {
                Console.WriteLine("Target was not found in the array");
            }
            
        }

        private static int FindIndexOfNumber(List<int> data, int target)
        {
            int first = 0, last = data.Count - 1, mid = 0;

            while (first <= last)
            {
                mid = (last + first) / 2;

                if (target > data[mid])
                {
                    first = mid + 1;
                }

                else if (target < data[mid])
                {
                    last = mid - 1;
                }

                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
