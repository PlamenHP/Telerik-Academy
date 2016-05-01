//  Problem 10. N Factorial
//  
//      Write a program to calculate n! for each n in the range[1..100].
//  
//  Hint: Implement first a method that multiplies a number represented as array of digits 
//  by given integer number.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NFactorial
    {
        static void Main()
        {
            List<int> lastResult = new List<int>();

            lastResult.Add(1);
            for (int i = 1; i <= 100; i++)
            {
                lastResult = MultiplyNumbers(lastResult, i);
                //lastResult.Reverse();
                Console.Write("{0}! = ",i);
                for (int j = lastResult.Count - 1; j >= 0; j--)
                {
                    Console.Write(lastResult[j]);
                }
                Console.WriteLine();
            }
        }

        private static List<int> MultiplyNumbers(List<int> data, int num)
        {
            int carry = 0;
            int sum = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < data.Count; i++)
            {
                sum = num * data[i] + carry;
                carry = 0;
                if (sum > 9)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }
                result.Add(sum);
            }

            if (carry != 0)
            {
                string rm = carry.ToString();
                for (int i = rm.Length -1; i >=0 ; i--)
                {
                    result.Add(rm[i]-'0');
                }
                
            }
            return result;
        }
    }
}
