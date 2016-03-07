using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Long_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = 1000;
            int sequenceStartDigit = 2;
            int digit = 0;

            for (int i = 0; i < sequenceLength; i++)
            {
                digit = sequenceStartDigit + i;

                if ((digit % 2) == 0)
                {
                    Console.WriteLine(digit);
                }
                else
                {
                    digit *= -1;
                    Console.WriteLine(digit);
                }
            }
        }
    }
}
