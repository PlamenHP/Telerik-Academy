//  Problem 14. Quick sort
//  
//      Write a program that sorts an array of integers using the Quick sort algorithm.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class QuickSort
    {
        static void Main()
        {
            Console.WriteLine("Problem 14. Quick sort\n");
            Console.WriteLine("Enter a sequence in the format: 2, 3, -6, -1, 2, -1, 6, 4, -8, 8");
            List<int> data = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries).Select(x => int.Parse(x))
                .ToList();

            QSort(data, 0, data.Count-1);

            Console.WriteLine(string.Join(", ", data));
        }

        private static void QSort(List<int> data, int start, int end)
        {
            int tmp = 0;
            int low = start;
            int high = end;
            int mid = (low + high) / 2;

            while (low <= high)
            {
                while (data[low] < data[mid])
                    low++;
                while (data[high] > data[mid])
                    high--;
                if (low <= high)
                {
                    tmp = data[low];
                    data[low] = data[high];
                    data[high] = tmp;
                    low++;
                    high--;
                }
            }

            if (start < high)
                QSort(data, start, high);
            if (low < end)
                QSort(data, low, end);
        }
    }
}
