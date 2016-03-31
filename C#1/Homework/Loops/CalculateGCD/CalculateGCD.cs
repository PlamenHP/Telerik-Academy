//  Problem 17.* Calculate GCD
//  
//      Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//      Use the Euclidean algorithm (find it in Internet).
//  
//  Examples:
//  a 	    b 	    GCD(a, b)
//  3 	    2 	    1
//  60  	40  	20
//  5 	   -15  	5

namespace Namespace
{
    using System;
    class CalculateGCD
    {
        static void Main()
        {
            Console.WriteLine("Calculate GCD \n");
            Console.Write("enter integer a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter integer b= ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(GCD(a,b));
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

    }
}
