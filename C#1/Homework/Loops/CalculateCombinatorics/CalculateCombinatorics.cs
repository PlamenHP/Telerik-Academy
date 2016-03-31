//  Problem 7. Calculate N! / (K! * (N-K)!)
//  
//      In combinatorics, the number of ways to choose k different members out of a group of n different elements
//      (also known as the number of combinations) is calculated by the following formula: n! / (k! * (n-k)!) 
//      For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//      Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//      Try to use only two loops.
//  
//  Examples:
//  n 	k 	n! / (k! * (n-k)!)
//  3 	2 	3
//  4 	2 	6
//  10 	6 	210
//  52 	5 	2598960

namespace Namespace
{
    using System;
    using System.Numerics;
    class CalculateCombinatorics
    {
        static void Main()
        {
            Console.Write("enter integer number (1 < n < 100) n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter integer number (1 < k < n < 100) k= ");
            int k = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(n) / (Factorial(k)* Factorial(n-k));
            Console.WriteLine("{0}", result);
        }

        private static BigInteger Factorial(int digit)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= digit; i++)
			{
                factorial *= i;
			}
            return factorial;
        }
    }
}
