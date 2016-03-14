//  Problem 4. Number Comparer
//  
//      Write a program that gets two numbers from the console and prints the greater of them.
//      Try to implement this without if statements.
//  
//  Examples:
//  a 	 b 	  greater
//  5 	 6 	    6
//  10 	 5 	    10
//  0 	 0   	0
//  -5 	 -2 	-2
//  1.5  1.6 	1.6

namespace Namespace
{
    using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.Write("enter number a: ");
            long a = long.Parse(Console.ReadLine());
            Console.Write("enter number b: ");
            long b = long.Parse(Console.ReadLine());

            Console.WriteLine("Thegreater number is: {0}", a > b ? a : b);
        }
    }
}
