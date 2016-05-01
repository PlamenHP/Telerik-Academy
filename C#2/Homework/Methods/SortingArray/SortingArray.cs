// Problem 9. Sorting array
// 
//     Write a method that return the maximal element in a portion of array of integers 
//     starting at given index.
//     Using it write another method that sorts an array in ascending / descending order.
// 

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortingArray
    {
        static void Main()
        {
            //generate random array
            Random rnd = new Random();
            int length = rnd.Next(10, 20);
            List<int> data = new List<int>(length);

            for (int i = 0; i < length; i++)
            {
                data.Add(rnd.Next(0, 10));
            }
            data.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine();

            Console.WriteLine("\nSort ascending");
            SortAscending(data);
            data.ForEach(x => Console.Write("{0} ",x));
            Console.WriteLine();

            Console.WriteLine("\nSort descending");
            SortDescending(data);
            data.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine();
        }

        private static void SortAscending(List<int> data)
        {
            int temp = 0;
            int indexOfMax = 0;

            for (int i = data.Count-1; i >=0; i--)
            {
                indexOfMax = GetIndexOfMax(data,0, i);
                temp = data[i];
                data[i] = data[indexOfMax];
                data[indexOfMax] = temp;
            }
        }

        private static void SortDescending(List<int> data)
        {
            int temp = 0;
            int indexOfMax = 0;

            for (int i = 0; i < data.Count; i++)
            {
                indexOfMax = GetIndexOfMax(data, i, data.Count-1);
                temp = data[i];
                data[i] = data[indexOfMax];
                data[indexOfMax] = temp;
            }
        }

        private static int GetIndexOfMax(List<int> data, int from, int to)
        {
            int indexOfMax = from;

            for (int i = from+1; i <= to; i++)
            {
                if (data[i]>data[indexOfMax])
                {
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }
    }
}
