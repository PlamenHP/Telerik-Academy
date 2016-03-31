//  Problem 16. Decimal to Hexadecimal Number
//  
//      Using loops write a program that converts an integer number to its hexadecimal representation.
//      The input is entered as long. The output should be a variable of type string.
//      Do not use the built-in .NET functionality.
//  
//  Examples:
//  decimal 	    hexadecimal
//  254 	        FE
//  6883 	        1AE3
//  338583669684 	4ED528CBB4

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Decimal to Hexadecimal numberber \n");
            Console.Write("enter integer numberber n= ");
            long number = long.Parse(Console.ReadLine());
            int reminder = 0;
            string result = string.Empty;

            while (number > 0)
            {
                reminder = (int)(number % 16);
                number = number / 16;
                result = result + ToHex(reminder);
            }

            Console.WriteLine(result);
        }

        private static string ToHex(int hex)
        {
            List<string> map = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            return map[hex];
        }
    }
}
