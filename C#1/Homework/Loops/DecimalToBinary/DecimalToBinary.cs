//  Problem 14. Decimal to Binary numberber
//  
//      Using loops write a program that converts an integer numberber to its binary representation.
//      The input is entered as long. The output should be a variable of type string.
//      Do not use the built-in .NET functionality.
//  
//  Examples:
//  decimal 	binary
//  0 	        0
//  3 	        11
//  43691 	    1010101010101011
//  236476736 	1110000110000101100101000000

namespace Namespace
{
    using System;
    using System.Text;
    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Decimal to Binary numberber /n");
            Console.Write("enter integer numberber n= ");
            long number = long.Parse(Console.ReadLine());
            long reminder = 0;
            string result = string.Empty;
            while (number > 0)
            {
                reminder = number % 2;
                number = number / 2;
                result = reminder.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
