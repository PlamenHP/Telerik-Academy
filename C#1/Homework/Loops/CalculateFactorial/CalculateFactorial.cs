//  Problem 6. Calculate N! / K!
//  
//      Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//      Use only one loop.
//  
//  Examples:
//  n 	k 	n! / k!
//  5 	2 	60
//  6 	5 	6
//  8 	3 	6720

namespace Namespace
{
    using System;
    using System.Numerics;
    class CalculateFactorial
    {
        static void Main()
        {
            Console.Write("enter integer number (1 < n < 100) n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter integer number (1 < k < n < 100) k= ");
            int k = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(n) / Factorial(k);
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
