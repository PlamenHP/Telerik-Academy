//  Problem 10. Fibonacci Numbers
//  
//      Write a program that reads a number n and prints on the console the first n members
//      of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 
//      0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//  
//  Note: You may need to learn how to use loops.
//  
//  Examples:
//  n 	comments
//  1 	0
//  3 	0 1 1
//  10 	0 1 1 2 3 5 8 13 21 34

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("enter integer n: ");
            int n = int.Parse(Console.ReadLine());

            List<BigInteger> fib = new List<BigInteger>();
            for (int i = 0; i < n; i++)
            {
                fib.Add(i > 1 ? fib[i - 1] + fib[i - 2] : i);
            }

            Console.WriteLine(String.Join(", ",fib));
        }
    }
}
