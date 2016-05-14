//  Problem 1. Decimal to binary
//  
//      Write a program to convert decimal numbers to their binary representation.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            int number = int.Parse(Console.ReadLine());

            string result = DecToBinary1(number);
            Console.WriteLine("Binary v1:  {0}", result);

            result = DecToBinary2(number);
            Console.WriteLine("Binary v2:  {0}", result);

        }

        // for converting very big numbers
        private static string DecToBinary(BigInteger number)
        {
            StringBuilder binary = new StringBuilder();
            int reminder = 0;

            while (number > 0)
            {
                reminder = (int)BigInteger.Remainder(number, 2);
                number = number / 2;
                binary.Append(reminder.ToString());
            }
            string result = binary.ToString();
            result = new string(result.Reverse().ToArray());
            result.TrimStart('0');
            return result;
        }

        private static string DecToBinary1(int number)
        {
            string result = Convert.ToString(number, 2);
            return result;
        }

        private static string DecToBinary2(int number)
        {
            string result = String.Empty;
            int reminder = 0;
            while (number > 0)
            {
                reminder = number % 2;
                number = number / 2;
                result = reminder.ToString() + result;
            }
            return result;
        }
    }
}
