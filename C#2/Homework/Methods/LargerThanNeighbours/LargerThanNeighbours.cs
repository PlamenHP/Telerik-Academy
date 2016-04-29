//  Problem 5. Larger than neighbours
//
//    Write a method that checks if the element at given position in 
//    given array of integers is larger than its two neighbours(when such exist).


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LargerThanNeighbours
    {
        static void Main()
        {
            Random rnd = new Random();
            int length = rnd.Next(10, 20);
            List<int> data = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                data.Add(rnd.Next(0, 10));
            }
            data.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine();

            int position = rnd.Next(0, length);
            bool largerThanBothNeibhors = LargerThanBothNeibhors(data, position);
            Console.WriteLine("element at position {0} is {1} than its two neibhors", position,largerThanBothNeibhors?"larger":"not larger");
        }

        private static bool LargerThanBothNeibhors(List<int> data, int position)
        {
            bool largerThanBothNeibhors = false;
            bool largerThenPrevious = false;
            bool largerThanNext = false;

            if (position > 0)
            {
                largerThenPrevious = data[position] > data[position - 1] ? true : false;
            }
            if (position < data.Count - 1)
            {
                largerThanNext = data[position] > data[position + 1] ? true : false;
            }

            largerThanBothNeibhors = largerThenPrevious && largerThanNext;
            return largerThanBothNeibhors;
        }
    }
}
