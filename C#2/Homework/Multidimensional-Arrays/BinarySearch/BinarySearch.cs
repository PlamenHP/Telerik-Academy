//   Problem 4. Binary search
//
//    Write a program, that reads from the console an array of N integers and an integer K, 
//    sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
//

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ProBinarySearchgram
    {
        static void Main()
        {
            Console.WriteLine(" Problem 4. Binary search\n");
            Console.Write("Enter the lenght of the array N= ");
            int arraylenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array:");

            int[] array = new int[arraylenght];
            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("element[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter an integer K= ");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int index = Array.BinarySearch(array, k);

            if (index < 0)
            {
                index = ~index - 1;
            }
            Console.WriteLine("{0}", array[index]);
        }
    }
}
