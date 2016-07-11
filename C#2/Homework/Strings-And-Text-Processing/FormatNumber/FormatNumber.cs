
//  Problem 11. Format number
//  
//      Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//      Format the output aligned right in 15 symbols.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class FormatNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}",number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0,15:#0.##%}", number));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0,15:0.###E+0}", number));
        }
    }
}
