//  Problem 10. Odd and Even Product
//  
//      You are given n integers (given in a single line, separated by a space).
//      Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//      Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//  
//  Examples:
//  numbers 	        result
//  2 1 1 6 3 	        yes
//  product = 6 	
//  	
//  3 10 4 6 5 1 	    yes 
//  product = 60 	
//  	
//  4 3 2 5 2 	        no
//  odd_product = 16 	
//  even_product = 15 	

namespace Namespace
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("enter 'n' integers in a single line, separated by a space: ");
            string numbers = Console.ReadLine().TrimEnd(' ');
            List<string> digits = numbers.Split(' ').ToList();

            int odd_product = 1;
            int even_product = 1;
            for (int i = 0; i < digits.Count; i++)
            {
                if ((i+1) % 2 == 0)
                    even_product *= int.Parse(digits[i]);
                else
                    odd_product *= int.Parse(digits[i]);
            }
            Console.WriteLine(odd_product == even_product? "yes":"no");
        }
    }
}
