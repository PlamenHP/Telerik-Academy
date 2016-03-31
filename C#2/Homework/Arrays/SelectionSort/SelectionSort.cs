//  Problem 7. Selection sort
//  
//      Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//      Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//      find the smallest from the rest, move it at the second position, etc.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine(" Problem 7. Selection sort\n");
            Console.WriteLine("Enter a integers in the format: 2, 1, 1, 2 ...");
            List<int> array = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            List<int> result = Sort(array);

            Console.WriteLine(string.Join(", ", result));    
        }

        private static List<int> Sort(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                int minIndex = i;

                for (int j = i; j < array.Count; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                array.Swap(i, minIndex);
            }
            return array;
        }
    }
}
