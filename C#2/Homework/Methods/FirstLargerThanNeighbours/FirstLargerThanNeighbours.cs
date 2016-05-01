//  Problem 6. First larger than neighbours
//  
//      Write a method that returns the index of the first element in array that is larger 
//      than its neighbours, or -1, if there’s no such element.
//      Use the method from the previous exercise.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FirstLargerThanNeighbours
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
            int result = FirstLargerThanBothNeibhors(data, position);

            Console.WriteLine("{0}",result==-1?"not found: -1":"fount at: "+result);
        }

        private static int FirstLargerThanBothNeibhors(List<int> data, int position)
        {
            int resultPosition = -1;
            for (position = 0; position < data.Count; position++)
            {
                if (LargerThanBothNeibhors(data, position))
                {
                    resultPosition = position;
                    break;
                }
            }
            return resultPosition;
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
