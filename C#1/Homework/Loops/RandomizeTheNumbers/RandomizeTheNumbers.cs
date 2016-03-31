//  Problem 12.* Randomize the Numbers 1…N
//  
//      Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//  
//  Examples:
//  n 	    randomized numbers 1…n
//  3 	    2 1 3
//  10 	    3 4 8 2 6 7 9 1 10 5
//  
//  Note: The above output is just an example. Due to randomness, your program most probably will produce
//        different results. You might need to use arrays.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    class RandomizeTheNumbers
    {
        static void Main()
        {
            Console.WriteLine("Randomize the Numbers 1…N\n");
            Console.Write("enter integer n= ");
            int n = int.Parse(Console.ReadLine());

            Random randomGenerator = new Random();            
            List<int> numbers = Enumerable.Range(1, n).ToList();
            numbers = numbers.OrderBy(x => randomGenerator.Next()).ToList();

            numbers.ForEach(Console.WriteLine);

            //  int randomNumber = 0;
            //  List<int> randomised = new List<int>();
            //  
            //  for (int i = 0; i < n; i++)
            //  {
            //      randomNumber = randomGenerator.Next(0, numbers.Count - 1);
            //      randomised.Add(numbers[randomNumber]);
            //      numbers.RemoveAt(randomNumber);
            //      Thread.Sleep(100);
            //  }
            //  
            //  randomised.ForEach(Console.WriteLine);
        }
    }
}
