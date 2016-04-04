// Problem 13.* Merge sort
// 
//     Write a program that sorts an array of integers using the Merge sort algorithm.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MergeSort
    {
        static void Main()
        {
            Console.WriteLine("Problem 13.* Merge sort\n");
            Console.WriteLine("Enter a sequence in the format: 2, 3, -6, -1, 2, -1, 6, 4, -8, 8");
            List<int> data = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries).Select(x => int.Parse(x))
                .ToList();

            Sort(data,0,data.Count);

            Console.WriteLine(string.Join(", ",data));

        }

        private static void Sort(List<int> data, int low, int high)
        {
            int N = high - low;
            if (N <= 1)
                return;

            int mid = low + N / 2;

            Sort(data, low, mid);
            Sort(data, mid, high);

            int[] aux = new int[N];
            int i = low, j = mid;
            for (int k = 0; k < N; k++)
            {
                if (i == mid) aux[k] = data[j++];
                else if (j == high) aux[k] = data[i++];
                else if (data[j].CompareTo(data[i]) < 0) aux[k] = data[j++];
                else aux[k] = data[i++];
            }

            for (int k = 0; k < N; k++)
            {
                data[low + k] = aux[k];
            }
        }
    }
}
