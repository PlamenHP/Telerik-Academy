//  Problem 7. Sum of 5 Numbers
//  
//      Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//  
//  Examples:
//  numbers 	         sum
//  1 2 3 4 5 	         15
//  10 10 10 10 10       50
//  1.5 3.14 8.2 -1 0 	 11.84

namespace Namespace
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            Console.Write("enters 5 numbers in a single line, separated by a space:");
            double sum = Console.ReadLine().Split(' ').Sum(c => double.Parse(c));       
            Console.WriteLine("sum={0}",sum);
        }
    }
}
