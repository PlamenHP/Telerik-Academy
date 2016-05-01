//  Problem 8. Number as array
//  
//      Write a method that adds two positive integer numbers represented as arrays 
//      of digits(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//      Each of the numbers that will be added could have up to 10 000 digits.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    class NumberAsArray
    {
        static void Main()
        {
            Console.Write("enter first integer: ");
            string input = Console.ReadLine();
            List<int> number1 = new List<int>();

            for (int i = (input.Length - 1); i >= 0; i--)
            {
                number1.Add(input[i] - '0');
            }
            Console.Write("enter second integer: ");
            input = Console.ReadLine();
            List<int> number2 = new List<int>();

            for (int i = (input.Length - 1); i >= 0; i--)
            {
                number2.Add(input[i] - '0');
            }
            List<int> result = AddNumbers(number1, number2);
            Console.Write("first + second = ");
            result.Reverse();
            result.ForEach(x => Console.Write(x));


            Console.WriteLine();
        }

        private static List<int> AddNumbers(List<int> v1, List<int> v2)
        {
            int reminder = 0;
            int sum = 0;

            if (v1.Count > v2.Count)
            {
                List<int> tmp = v1;
                v1 = v2;
                v2 = tmp;
            }
            int length = v2.Count;
            List<int> result = new List<int>();

            for (int i = 0; i < length; i++)
            {
                sum = (v1.Count > i ? v1[i] : 0) + v2[i] + reminder;
                reminder = 0;
                if (sum>9)
                {
                    reminder = sum / 10;
                    sum = sum % 10;
                }
                result.Add(sum);
            }

            if (reminder !=0)
            {
                result.Add(reminder);
            }
            return result;
        }
    }
}
