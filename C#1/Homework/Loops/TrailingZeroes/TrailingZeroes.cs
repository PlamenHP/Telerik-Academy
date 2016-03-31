//  Problem 18.* Trailing Zeroes in N!
//  
//      Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//      Your program should work well for very big numbers, e.g. n=100000.
//  
//  Examples:
//  n 	        trailing zeroes of n! 	explanation
//  10 	        2 	                    3628800
//  20      	4 	                    2432902008176640000
//  100000  	24999 	                think why

namespace Namespace
{
    using System;
    using System.Numerics;
    class TrailingZeroes
    {
        static void Main()
        {
            Console.WriteLine("Trailing Zeroes in N! \n ");
            Console.Write("enter integer number n= ");
            int number = int.Parse(Console.ReadLine());

            int trailingZeroes = GetTrailingZeroes(number);

            Console.WriteLine("{0}", trailingZeroes);
        }

        private static int GetTrailingZeroes(int number)
        {
            int trailingZeroes = 0;
            int pow=1;
            int result = 0;
            do
            {   
                result = (int)(number / Math.Pow(5, pow));
                trailingZeroes = trailingZeroes + result;
                pow++;
            }
            while (result > 0);

            return trailingZeroes;
        }

        // GetTrailingZeroes() example:
        // 5^1 :  4617 ÷ 5 = 923.4, so I get 923 factors of 5
        // 5^2 :  4617 ÷ 25 = 184.68, so I get 184 additional factors of 5
        // 5^3 :  4617 ÷ 125 = 36.936, so I get 36 additional factors of 5
        // 5^4 :  4617 ÷ 625 = 7.3872, so I get 7 additional factors of 5
        // 5^5 :  4617 ÷ 3125 = 1.47744, so I get 1 more factor of 5
        // 5^6 :  4617 ÷ 15625 = 0.295488, which is less than 1, so I stop here.
        //
        // Then 4617! has 923 + 184 + 36 + 7 + 1 = 1151 trailing zeroes.
    }
}
