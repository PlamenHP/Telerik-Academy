//  Problem 6. The Biggest of Five Numbers
//  
//      Write a program that finds the biggest of five numbers by using only five if statements.
//  
//  Examples:
//  a 	b 	  c 	d 	e 	biggest
//  5 	2 	  2 	4 	1 	 5
// -2  -22 	  1 	0 	0 	 1
// -2 	4 	  3 	2 	0 	 4
//  0  -2.5   0 	5 	5 	 5
// -3  -0.5  -1.1  -2  -0.1 -0.1

namespace Namespace
{
    using System;
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("The Biggest of Five Numbers\n");
            Console.Write("enter a real number a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter a real number b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter a real number c= ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("enter a real number d= ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("enter a real number e= ");
            double e = double.Parse(Console.ReadLine());
            
            double BiggestNumber = double.MinValue;

            if (a >= b) BiggestNumber = a;
            else        BiggestNumber = b;

            if (b >= c) BiggestNumber = b;
            else        BiggestNumber = c;

            if (c >= d) BiggestNumber = c;
            else        BiggestNumber = d;

            if (d >= e) BiggestNumber = d;
            else        BiggestNumber = e;

            Console.WriteLine(BiggestNumber);
        }
    }
}
