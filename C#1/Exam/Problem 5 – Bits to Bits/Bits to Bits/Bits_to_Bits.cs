using System;
using System.Collections.Generic;

namespace Bits_to_Bits
{
    public class Bits_to_Bits
    {
        public static void Main()
        {
            int numberRows = int.Parse(Console.ReadLine());
            List<long> numbersList = new List<long>();
            for (int i = 0; i < numberRows; i++)
            {
                numbersList.Add(long.Parse(Console.ReadLine()));
            }

            int maskLength = 30;
            int currentZeros = 0;
            int maxZeros = 0;
            int currentOnes = 0;
            int maxOnes = 0;
            long bit = 0;
            long mask = 0;

            foreach (var number in numbersList)
            {
                for (int i = maskLength - 1; i >= 0; i--)
                {
                    mask = 1 << i;
                    bit = (number & mask) >> i;
                    mask = 0;

                    if (bit == 0)
                    {
                        currentOnes = 0;
                        currentZeros++;
                    }
                    else
                    {
                        currentOnes++;
                        currentZeros = 0;
                    }

                    if (currentOnes > maxOnes)
                    {
                        maxOnes = currentOnes;
                    }

                    if (currentZeros > maxZeros)
                    {
                        maxZeros = currentZeros;
                    }
                }
            }
            Console.WriteLine(maxZeros);
            //Console.WriteLine();
            Console.WriteLine(maxOnes);
        }
    }
}
