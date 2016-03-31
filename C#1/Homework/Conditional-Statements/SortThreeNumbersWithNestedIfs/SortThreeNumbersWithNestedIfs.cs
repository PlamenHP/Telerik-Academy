//  Problem 7. Sort 3 Numbers with Nested Ifs
//  
//      Write a program that enters 3 real numbers and prints them sorted in descending order.
//          Use nested if statements.
//  
//  Note: Don’t use arrays and the built-in sorting functionality.
//  
//  Examples:
//  a   	b   	c 	    result
//  5 	    1    	2   	5 2 1
//  -2  	-2  	1   	1 -2 -2
//  -2 	    4 	    3 	    4 3 -2
//  0 	    -2.5    5 	    5 0 -2.5
//  -1.1 	-0.5 	-0.1 	-0.1 -0.5 -1.1
//  10  	20 	    30 	    30 20 10
//  1 	    1 	    1 	    1 1 1

namespace Namespace
{
    using System;
    class SortThreeNumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("Sort 3 Numbers with Nested Ifs\n");
            Console.Write("enter a real number a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter a real number b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter a real number c= ");
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c) Write(a, b, c);
                else if (a > c) Write(a, c, b);
                else Write(c, a, b);

            }
            else
            {
                if (a > c) Write(b, a, c);
                else if (b > c) Write(b, c, a);
                else Write(c, b, a);

            }
        }

        private static void Write(double first, double second, double third)
        {
            Console.WriteLine("{0} {1} {2}", first, second, third);
        }
    }
}
