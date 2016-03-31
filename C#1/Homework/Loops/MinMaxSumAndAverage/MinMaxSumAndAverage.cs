﻿//  Problem 3. Min, Max, Sum and Average of N Numbers
//  
//      Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//      the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//      The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//      The output is like in the examples below.
//  
//  Example 1:
//  input 	output
//  3       min = 1
//  2       max = 5
//  5       sum = 8
//  1 	    avg = 2.67
//  
//  Example 2:
//  input 	output
//  2       min = -1
// -1       max = 4
//  4 	    sum = 3
//          avg = 1.50
//  
//  

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MinMaxSumAndAverage
    {
        static void Main()
        {
            Console.WriteLine("Min, Max, Sum and Average of N Numbers\n");
            Console.Write("enter n: ");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter integer {0} of {1}: ", i + 1, n);
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int min = numbers.Min(x => x);
            int max = numbers.Max(x => x);
            int sum = numbers.Sum(x => x);
            double avg = numbers.Average(x => x);

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
        }
    }
}
