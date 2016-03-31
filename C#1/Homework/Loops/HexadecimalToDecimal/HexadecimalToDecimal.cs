//  Problem 15. Hexadecimal to Decimal Number
//  
//      Using loops write a program that converts a hexadecimal integer number to its decimal form.
//      The input is entered as string. The output should be a variable of type long.
//      Do not use the built-in .NET functionality.
//  
//  Examples:
//  hexadecimal 	    decimal
//  FE 	                254
//  1AE3            	6883
//  4ED528CBB4       	338583669684

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Hexadecimal to Decimal Number \n");
            Console.Write("enter a Hexadecimal number 0x= ");
            string hex = Console.ReadLine();
            long output = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                if (hex[hex.Length - i - 1] == '0')
                    continue;
                else
                    output += ToDecimal(hex[hex.Length - i - 1]) * (long)Math.Pow(16, i);
            }
            Console.WriteLine(output);
        }

        private static long ToDecimal(char hex)
        {
            hex = (hex.ToString().ToUpper())[0];
            List<char> map = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            return map.IndexOf(hex);
        }
    }
}
