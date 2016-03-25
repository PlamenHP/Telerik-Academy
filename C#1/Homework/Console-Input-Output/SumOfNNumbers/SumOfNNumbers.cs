//  Problem 9. Sum of n Numbers
//  
//      Write a program that enters a number n and after that enters more n numbers 
//      and calculates and prints their sum. Note: You may need to use a for-loop.
//  
//  Examples:
//  numbers 	sum
//  3 	        90
//  20 	
//  60 	
//  10 	
//  5 	        6.5
//  2 	
//  -1 	
//  -0.5 	
//  4 	
//  2 	
//  1 	         1
//  1 	

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("enter integer n: ");
            int n = int.Parse(Console.ReadLine());

            List<double> numbers = new List<double>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter integer {0} of {1}: ",i+1,n);
                numbers.Add(double.Parse(Console.ReadLine()));
            }

            double sumOfNumbers = numbers.Sum(x => x);
            Console.WriteLine(sumOfNumbers);
        }
    }
}
