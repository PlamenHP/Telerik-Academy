//  Problem 15. Prime numbers
//  
//      Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

namespace Namespace
{
    using System;
    using System.Collections.Generic;

    class PrimeNumbers
    {
        static void Main()
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int range = 10000000;

            for (int testNumber = 3; testNumber < range; testNumber += 2)
            {
                bool isPrime = true;

                for (int item = 0; primes[item] <= Math.Floor(Math.Sqrt(testNumber)); item++)
                {
                    if (testNumber % primes[item] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) primes.Add(testNumber);
            }
            Console.WriteLine(string.Join(", ", primes));
        }
    }
}
