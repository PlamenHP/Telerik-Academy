//  Problem 7. One system to any other
//  
//      Write a program to convert from any numeral system of given base s 
//      to any other numeral system of base d.  (2 ≤ s, d ≤ 16).


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OneSystemToAnyOther
    {
        static void Main()
        {
            Console.Write("Numerical system base to convert from (2<= S <= 16) S= ");
            int fromBase = int.Parse(Console.ReadLine());
            Console.Write("Numerical system base to convert to (2<= D <= 16) D= ");
            int toBase = int.Parse(Console.ReadLine());
            Console.Write("Enter number in {0} based format: ",fromBase);
            string number = Console.ReadLine();

            int dec = Convert.ToInt32(number, fromBase);
            string result = Convert.ToString(dec, toBase);

            Console.WriteLine("Result: {0}",result);
        }
    }
}
