//  Problem 2. Reverse string
//  
//      Write a program that reads a string, reverses it and prints the result at the console.
//  
//  Example:
//  input output
//  sample elpmas

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            string result = new string(input.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
