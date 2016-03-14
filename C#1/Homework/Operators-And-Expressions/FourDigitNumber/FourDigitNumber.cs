//  Problem 6. Four-Digit Number
//  
//      Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//          Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//          Prints on the console the number in reversed order: dcba (in our example 1102).
//          Puts the last digit in the first position: dabc (in our example 1201).
//          Exchanges the second and the third digits: acbd (in our example 2101).
//  
//  The number has always exactly 4 digits and cannot start with 0.
//  
//  Examples:
//  n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
//  2011 	4 	        1102 	     1201 	                   2101
//  3333 	12       	3333 	     3333 	                   3333
//  9876 	30      	6789 	     6987 	                   9786

namespace Namespace
{
    using System;
    using System.Linq;
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("input a four-digit number in format abcd (e.g. 2011):");
            string digit = Console.ReadLine();

            int sumOfDigits = digit.Sum(c => c - '0');
            Console.WriteLine(sumOfDigits);

            var reverseOrderDigits = digit.Reverse().ToArray();
            Console.WriteLine(reverseOrderDigits);

            string lastDigitInFront = String.Format("{0}{1}",digit[3],digit.Substring(0,3));
            Console.WriteLine(lastDigitInFront);

            string exchangedDigits = String.Format("{0}{1}{2}{3}", digit[0], digit[2], digit[1], digit[3]);
            Console.WriteLine(exchangedDigits);
        }
    }
}
