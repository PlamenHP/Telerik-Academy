//  Problem 2. Binary to decimal
//  
//      Write a program to convert binary numbers to their decimal representation.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();

            int result = BinToDecimal1(binary);
            Console.WriteLine(result);

            result = BinToDecimal2(binary);
            Console.WriteLine(result);
        }

        private static int BinToDecimal1(string binary)
        {
            int result = Convert.ToInt32(binary,2);
            return result;
        }

        private static int BinToDecimal2(string binary)
        {
            double result = 0;

            for (int i = 0; i < binary.Length ; i++)
            {
                result = result + ((byte)binary[i] - 48) * Math.Pow(2, ((binary.Length - i) - 1));
            }
            return (int)result;
        }
    }
}
