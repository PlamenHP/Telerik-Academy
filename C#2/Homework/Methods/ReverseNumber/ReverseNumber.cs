//   Problem 7. Reverse number
//   
//       Write a method that reverses the digits of given decimal number.
//   
//   Example:
//   input      output
//   256    	652
//   123.45 	54.321

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("enter number: ");
            string number = Console.ReadLine();

            number = Reverse(number);
            
            Console.WriteLine(number);
        }

        private static string Reverse(string number)
        {
            return new string(number.Reverse().ToArray());
        }
    }
}
