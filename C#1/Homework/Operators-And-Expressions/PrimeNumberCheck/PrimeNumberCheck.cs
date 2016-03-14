//  Problem 8. Prime Number Check
//  
//      Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//      Note: You should check if the number is positive
//  
//  Examples:
//  n 	Prime?
//  1 	false
//  2 	true
//  3 	true
//  4 	false
//  9 	false
//  97 	true
//  51 	false
//  -3 	false
//  0 	false

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Console.Write("enter integer less than 101: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = false;

            if (number > 1)
            {
                if (number == 2 || number == 3 || number == 5 || number == 7)
                {
                    isPrime = true;
                }
                else if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0))
                {
                    isPrime = true;
                }
            }
            Console.WriteLine("number is prime?: {0}", isPrime);
        }
    }
}
