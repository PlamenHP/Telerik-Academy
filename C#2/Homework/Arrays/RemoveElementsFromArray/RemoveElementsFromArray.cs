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

            int n = int.Parse(Console.ReadLine());
            List<int> array = new List<int>(n);
            List<int> count = new List<int>(n);
            List<int> parent = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                array.Add(int.Parse(Console.ReadLine()));
                count.Add(1);
                parent.Add(-1);
            }

            for (int i = 1; i < array.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] <= array[i])
                    {
                        if (parent[i] == -1)
                        {
                            parent[i] = j;
                            count[i] = count[j] + 1;
                        }
                        else
                        {
                            if (count[j] > count[parent[i]])
                            {
                                parent[i] = j;
                                count[i] = count[j] + 1;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(n - count.Max());
        }
    }
}
