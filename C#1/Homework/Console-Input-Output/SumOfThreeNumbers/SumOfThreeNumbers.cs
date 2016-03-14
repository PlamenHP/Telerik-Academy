//  Problem 1. Sum of 3 Numbers
//  
//      Write a program that reads 3 real numbers from the console and prints their sum.
//  
//  Examples:
//  a 	  b 	c 	    sum
//  3 	  4 	11   	18
//  -2    0 	3 	    1
//  5.5  4.5 	20.1 	30.1

namespace Namespace
{
    using System;
    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.Write("enter real number a: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("enter real number b: ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.Write("enter real number c: ");
            decimal c = decimal.Parse(Console.ReadLine());

            Console.WriteLine(a+b+c);
        }
    }
}
