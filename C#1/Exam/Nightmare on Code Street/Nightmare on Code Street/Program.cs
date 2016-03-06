using System;

namespace Nightmare_on_Code_Street
{
    class Nightmare_on_Code_Street
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int totalOddNumbers = 0;
            int sum = 0;
            for (int i = 1; i < input.Length; i+=2)
            {
                if ((input[i] >= '0') && (input[i] <= '9'))
                {
                    totalOddNumbers++;
                    sum += (input[i] - '0');
                }
            }

            Console.Write(totalOddNumbers);
            Console.Write(" ");
            Console.Write(sum);
        }
    }
}
