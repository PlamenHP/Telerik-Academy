//    Problem 1. Say Hello
//  
//      Write a method that asks the user for his name and prints “Hello, <name>”
//      Write a program to test this method.
//  
//  Example:
//  input output
//  Peter Hello, Peter!

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SayHello
    {
        static void Main()
        {
            PrintHelloName();
        }

        private static void PrintHelloName()
        {
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
