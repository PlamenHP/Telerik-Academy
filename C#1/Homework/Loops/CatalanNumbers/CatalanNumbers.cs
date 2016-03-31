//  Problem 8. Catalan Numbers
//  
//      In combinatorics, the Catalan numbers are calculated by the following formula: 
//      catalan-formula (2n)!/((n+1)!*n!)
//      Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//        
//  Examples:
//  n 	Catalan(n)
//  0 	1
//  5 	42
//  10 	16796
//  15 	9694845

namespace Namespace
{
    using System;
    using System.Numerics;
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("enter integer number  (0 ≤ n ≤ 100) n= ");
            int n = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(2*n) / (Factorial(n+1) * Factorial(n));
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
