//   Problem 16.** Bit Exchange (Advanced)
//   
//       Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//       The first and the second sequence of bits may not overlap.
//   
//   Examples:
//   n 	            p 	q 	k 	binary representation of n 	            binary result 	result
//   1140867093 	3 	24 	3 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
//   4294901775 	24 	3 	3 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
//   2369124121 	2 	22 	10 	10001101 00110101 11110111 00011001 	01110001 10110101 11111000 11010001 	1907751121
//   987654321 	    2 	8 	11 	00111010 11011110 01101000 10110001 	- 	overlapping
//   123456789 	    26 	0 	7 	00000111 01011011 11001101 00010101 	- 	out of range
//   33333333333    -1 	0 	33 	00000111 11000010 11010010 01001101     01010101 	- 	out of range

namespace Namespace
{
    using System;
    class BitExchange_Advanced
    {
        static void Main()
        {
            Console.Write("enter integer n: ");
            long number = long.Parse(Console.ReadLine());
            Console.Write("enter integer p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("enter integer q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("enter integer k: ");
            int k = int.Parse(Console.ReadLine());
            int loopLength = p + k;

            long mask = 0;
            long maskAndNumber = 0;
            long result = 0;
            long bitP = 0;
            long bitQ = 0;

            if (CheckInput(p, q, k))
            {
                for (; p < loopLength; p++, q++)
                {
                    //get bit at p
                    mask = 1 << p;
                    maskAndNumber = mask & number;
                    bitP = maskAndNumber >> p;

                    //get bit at q
                    mask = 1 << q;
                    maskAndNumber = mask & number;
                    bitQ = maskAndNumber >> q;

                    //set bit p at q
                    if (bitP == 1)
                    {
                        mask = 1 << q;
                        result = mask | number;
                    }
                    else
                    {
                        mask = ~(1 << q);
                        result = mask & number;
                    }
                    number = result;

                    //set bit q at p
                    if (bitQ == 1)
                    {
                        mask = 1 << p;
                        result = mask | number;
                    }
                    else
                    {
                        mask = ~(1 << p);
                        result = mask & number;
                    }
                    number = result;
                }
                Console.WriteLine(number);
            }
        }

        private static bool CheckInput(int p, int q, int k)
        {
            // check if both numbers are in range
            if ((p < 0 || p > 32) || (q < 0 || q > 32))
            {
                Console.WriteLine("out of range");
                return false;
            }
            // check if both numbers overlap
            if ((p < q) && (p + k >= q) || (p > q) && (q + k >= p))
            {
                Console.WriteLine("overlapping");
                return false;
            }
            // check if any of the numbers + k goes out of range
            if ((q + k > 32) || (p + k > 32))
            {
                Console.WriteLine("out of range");
                return false;
            }
            return true;
        }
    }
}
