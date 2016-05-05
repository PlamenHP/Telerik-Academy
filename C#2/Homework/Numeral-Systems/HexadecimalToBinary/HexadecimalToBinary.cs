//  Problem 5. Hexadecimal to binary
//  
//      Write a program to convert hexadecimal numbers to binary numbers(directly).


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal number: ");
            string number = Console.ReadLine();

            string result = HexToBinary(number);
            Console.WriteLine(result);
        }

        private static string HexToBinary(string hexNum)
        {
            hexNum = hexNum.ToLower();
            StringBuilder result = new StringBuilder();

            foreach (char ch in hexNum)
            {
                result.Append(hexCharacterToBinary[ch]);
            }
            return result.ToString();
        }

        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string>
        {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'a', "1010" },
            { 'b', "1011" },
            { 'c', "1100" },
            { 'd', "1101" },
            { 'e', "1110" },
            { 'f', "1111" }
        };
    }
}

