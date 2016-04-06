//  Problem 18.* Remove elements from array
//  
//      Write a program that reads an array of integers and removes from it a minimal number of elements
//      in such a way that the remaining array is sorted in increasing order.
//      Print the remaining sorted array.
//  
//  Example:
//  input 	                        result
//  6, 1, 4, 3, 0, 3, 6, 4, 5 	    1, 3, 3, 4, 5

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveElementsFromArray
    {
        static void Main()
        {
            Console.WriteLine("Problem 18.* Remove elements from array\n");
            Console.WriteLine("Enter integers separated by coma and space, example: 6, 1, 4, 3, 0, 3, 6, 4, 5 \n");
            List<int> data = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            List<int> result = new List<int>(GetLongestSequence(data));

            Console.WriteLine("\n{0}",string.Join(", ", result));

        }

        private static List<int> GetLongestSequence(List<int> data)
        {
            List<int> max = new List<int>();
            List<int> temp = new List<int>();

            for (int i = 0; i < data.Count; i++)
            {
                temp = GetNode(data, i);

                if (temp.Count > max.Count)
                {
                    max = new List<int>(temp);
                }
            }
            return max;
        }

        private static List<int> GetNode(List<int> data, int current)
        {
            List<int> childs = new List<int>();
            // check for child nodes
            for (int next = current + 1; next < data.Count; next++)
            {
                if (data[current] <= data[next])
                {
                    childs.Add(next);
                }
            }

            List<int> max = new List<int>();
            // compare and select the max lenght result from child nodes
            if (childs.Count > 0)
            {
                List<int> temp = new List<int>();
                for (int i = 0; i < childs.Count; i++)
                {
                    temp = GetNode(data, childs[i]);

                    if (temp.Count > max.Count)
                    {
                        max = new List<int>(temp);
                    }
                }
            }

            // insert the current element in front and return
            max.Insert(0, data[current]);
            return max;
        }
    }
}
