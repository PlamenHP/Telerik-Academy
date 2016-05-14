//  Problem 4. Hexadecimal to decimal
//  
//      Write a program to convert hexadecimal numbers to their decimal representation

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter a Hex number: ");
            string hexNum = Console.ReadLine();

            BigInteger result = HexToDecimal(hexNum);
            Console.WriteLine(result);
        }

        private static int HexToDecimal1(string hexNum)
        {
            int result = 0;
            result = Convert.ToInt32(hexNum, 16);
            return result;
        }

        private static BigInteger HexToDecimal(string hexNum)
        {
            BigInteger result = 0;
            hexNum = hexNum.ToLower();

            for (int i = 0; i < hexNum.Length; i++)
            {
                char digit = hexNum[hexNum.Length - 1 - i];
                result += hexdecval[digit] * (BigInteger)Math.Pow(2, i);
            }
            return result;
        }

        private static Dictionary<char, int> hexdecval = new Dictionary<char, int>
        {
            {'0', 0},
            {'1', 1},
            {'2', 2},
            {'3', 3},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 7},
            {'8', 8},
            {'9', 9},
            {'a', 10},
            {'b', 11},
            {'c', 12},
            {'d', 13},
            {'e', 14},
            {'f', 15},
        };
    }
}
