
//      Write an expression that checks if given integer is odd or even.
//  
//  Examples:
//  n 	Odd?
//  3 	true
//  2 	false
//  -2 	false
//  -1 	true
//  0 	false

namespace OddOrEvenIntegers
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.Write("enter integer: ");
            int input = int.Parse(Console.ReadLine());

            bool even = (input % 2)==0 ? true : false;
            Console.WriteLine("the number is {0}", even ? "even" : "odd");
        }
    }
}
