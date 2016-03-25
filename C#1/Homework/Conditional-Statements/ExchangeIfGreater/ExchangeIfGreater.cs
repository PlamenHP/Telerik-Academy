// Problem 1. Exchange If Greater
// 
//     Write an if-statement that takes two double variables a and b and exchanges their values 
//     if the first one is greater than the second one. As a result print the values a and b, separated by a space.
// 
// Examples:
// a 	b 	    result
// 5 	2 	    2 5
// 3 	4 	    3 4
// 5.5 	4.5 	4.5 5.5

namespace Namespace
{
    using System;
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("enter first number a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter second number b=");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("you entered a={0} b={1}",a ,b);
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine();
            Console.WriteLine("after swap a={0} b={1}", a, b);
        }
    }
}
