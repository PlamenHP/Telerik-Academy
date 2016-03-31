//  Problem 13. Binary to Decimal Number
//  
//      Using loops write a program that converts a binary integer number to its decimal form.
//      The input is entered as string. The output should be a variable of type long.
//      Do not use the built-in .NET functionality.
//  
//  Examples:
//  binary 	                        decimal
//  0 	                            0
//  11          	                3
//  1010101010101011               	43691
//  1110000110000101100101000000 	236476736

namespace Namespace
{
    using System;
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Binary to Decimal Number \n");
            Console.Write("enter a binary number b= ");
            string binary = Console.ReadLine();
            long output = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i -1] == '0')
                    continue;
                else
                    output += (long)Math.Pow(2, i);
            }
            Console.WriteLine(output);
        }
    }
}
