//  Problem 2. Get largest number
//  
//      Write a method GetMax() with two parameters that returns the larger of two integers.
//      Write a program that reads 3 integers from the console and prints
//      the largest of them using the method GetMax().


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GetLargestNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integer: ");
            int third = int.Parse(Console.ReadLine());

            int largestInteger = GetMax(first,second);
            largestInteger = GetMax(largestInteger,third);

            Console.WriteLine("Largest integer = {0}", largestInteger);
         }

        static int GetMax(int value1, int value2)
        {
            int larger = value1 > value2 ? value1 : value2;
            return larger;
        }
    }
}
