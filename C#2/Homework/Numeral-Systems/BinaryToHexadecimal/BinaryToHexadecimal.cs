//  Problem 6. Binary to hexadecimal
//  
//      Write a program to convert binary numbers to hexadecimal numbers(directly).


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter a binary number: ");
            string number = Console.ReadLine();

            string result = BinaryToHex(number);
            Console.WriteLine(result);
        }

        private static string BinaryToHex(string number)
        {
            int rest = number.Length % 4;
            if (rest != 0)
            {
                number = new string('0', 4 - rest) + number;
            }

            StringBuilder result = new StringBuilder();
            StringBuilder hexCharacter = new StringBuilder();

            for (int i = 0; i < number.Length; i+=4)
            {
                hexCharacter.Clear();
                hexCharacter.Append(number, i, 4); 
                result.Append(binaryCharacterToHex[hexCharacter.ToString()]);
            }


            return result.ToString();
        }

        private static readonly Dictionary<string, char> binaryCharacterToHex = new Dictionary<string, char>
        {
            { "0000", '0'},
            { "0001", '1'},
            { "0010", '2'},
            { "0011", '3'},
            { "0100", '4'},
            { "0101", '5'},
            { "0110", '6'},
            { "0111", '7'},
            { "1000", '8'},
            { "1001", '9'},
            { "1010", 'A'},
            { "1011", 'B'},
            { "1100", 'C'},
            { "1101", 'D'},
            { "1110", 'E'},
            { "1111", 'F'}
        };
    }
}
