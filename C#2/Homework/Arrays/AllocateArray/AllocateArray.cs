//  Problem 1. Allocate array
//  
//      Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//      Print the obtained array on the console.


namespace Namespace
{
    using System;
    using System.Linq;
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 5;
            }

            numbers.ToList().ForEach(x => Console.WriteLine(x));
        }       
    }
}
