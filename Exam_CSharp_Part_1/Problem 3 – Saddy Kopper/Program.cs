using System;
using System.Collections.Generic;
using System.Numerics;

namespace Saddy_Kopper
{
    public class Saddy_Kopper
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            short transformations = 0;
            List<int> oddNumberSumList = new List<int>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
			{
			    numbers.Add(input[i] - '0');
			}

            while (numbers.Count > 1)
            {
                while (numbers.Count > 1)
                {
                    numbers.RemoveAt(numbers.Count-1);
                    int oddNumbersSum = 0;
                    for (int i = 0; i < numbers.Count; i++)
			        {
                        if (((i - '0') % 2) == 0)
                        {
                            oddNumbersSum += numbers[i];
                        }	 
			        }
                    oddNumberSumList.Add(oddNumbersSum);
                }

                BigInteger sumProduct = 1;
                foreach (var sum in oddNumberSumList)
                {
                    sumProduct *= sum;
                }
                oddNumberSumList.Clear();
                string newNumbers = sumProduct.ToString();
                numbers.Clear();
                for (int i = 0; i < newNumbers.Length; i++)
                {
                    numbers.Add(newNumbers[i] - '0');
                }
                transformations++;

                if (transformations == 10)
                {
                    break;
                }
            }

            if (transformations == 10)
            {
                string output= string.Join("",numbers);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(transformations.ToString());
                Console.WriteLine(numbers[0].ToString());
            }
        }
    }
}
