//  Problem 4. Hexadecimal to decimal
//  
//      Write a program to convert hexadecimal numbers to their decimal representation

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter a Hex number: ");
            string hexNum = Console.ReadLine();

            int result = HexToDecimal1(hexNum);
            Console.WriteLine(result);

            result = HexToDecimal2(hexNum);
            Console.WriteLine(result);
        }

        private static int HexToDecimal1(string hexNum)
        {
            int result = 0;
            result = Convert.ToInt32(hexNum,16);
            return result;
        }

        private static int HexToDecimal2(string hexNum)
        {
            int result = 0;
            hexNum = hexNum.ToUpper();

            for (int i = 0; i < hexNum.Length; i++)
            {
                if (hexNum[i] - '0'< 10)
                {
                    result = result + (hexNum[i] - '0');
                }
                else
                {
                    int temp = 0;

                    switch (hexNum[i])
                    {
                        case 'A': temp = 10; break;
                        case 'B': temp = 11; break;
                        case 'C': temp = 12; break;
                        case 'D': temp = 13; break;
                        case 'E': temp = 14; break;
                        case 'F': temp = 15; break;
                    }
                    result = result + temp*(int)Math.Pow(16, i);
                }
            }
            return result;
        }
    }
}
