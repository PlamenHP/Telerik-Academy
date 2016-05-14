//  Problem 8. Binary short
//  
//      Write a program that shows the binary representation of 
//      given 16-bit signed integer number(the C# type short).


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BinaryShort
    {
        static void Main()
        {
            Console.Write("Enter short integer number: ");
            short number = short.Parse(Console.ReadLine());

            string result = Convert.ToString(number,2);
            result = result.PadLeft(16,'0');
            Console.WriteLine(result);
        }
    }
}
