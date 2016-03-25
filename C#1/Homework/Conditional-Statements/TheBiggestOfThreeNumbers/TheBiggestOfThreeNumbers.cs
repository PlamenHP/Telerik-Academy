//  Problem 5. The Biggest of 3 Numbers
//  
//      Write a program that finds the biggest of three numbers.
//  
//  Examples:
//  a 	    b   	c 	    biggest
//  5 	    2 	    2 	    5
// -2 	   -2  	    1 	    1
// -2 	    4 	    3   	4
//  0 	   -2.5 	5 	    5
// -0.1    -0.5    -1.1    -0.1

namespace Namespace
{
    using System;
    class TheBiggestOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("The Biggest Of Three Numbers\n");
            Console.Write("enter a real number a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter a real number b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter a real number c= ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine((a>b)?(a>c?a:c):(b>c?b:c));
        }
    }
}
