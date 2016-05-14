//  Problem 3. Decimal to hexadecimal
//  
//      Write a program to convert decimal numbers to their hexadecimal representation.


namespace Namespace
{
    using System;
    using System.Numerics;

    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter a decimal number: ");
            int number = int.Parse(Console.ReadLine());

            string result = DecimalToHex1(number);
            Console.WriteLine(result);

            result = DecimalToHex2(number);
            Console.WriteLine(result);
        }

        private static string DecimalToHex1(int number)
        {
            string result = String.Empty;
            result = number.ToString("X");
            return result;
        }

        private static string DecimalToHex2(int number)
        {
            string result = String.Empty;

            while (number != 0)
            {
                if ((number % 16) < 10)
                {
                    result = number % 16 + result;
                }
                else
                {
                    string temp = "";

                    switch (number % 16)
                    {
                        case 10: temp = "A"; break;
                        case 11: temp = "B"; break;
                        case 12: temp = "C"; break;
                        case 13: temp = "D"; break;
                        case 14: temp = "E"; break;
                        case 15: temp = "F"; break;
                    }
                    result = temp + result;
                }
                number /= 16;
            }
            return result;
        }

        //for very large numbers
        private static string DecimalToHex(BigInteger decimalNumber)
        {
            string result = String.Empty;
            result = decimalNumber.ToString("X");
            result = result.TrimStart('0');
            return result;
        }
    }
}
