//  Problem 11. Adding polynomials
//  
//      Write a method that adds two polynomials.
//      Represent them as arrays of their coefficients.
//  
//  Example:
//  
//  x2 + 5 = 1x2 + 0x + 5 => { 5, 0, 1}

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AddingPolynomials
    {
        static void Main()
        {
            List<int> p1 = new List<int> { 5, 0, 1 };
            List<int> p2 = new List<int> { 5, 0, 1 };
            Console.WriteLine("p1 = {0}X^2 + {1}X + {2}       p2 = {3}X^2 + {4}X + {5}", p1[0],p1[1],p1[2],p2[0],p2[1],p2[2]);

            List<int> result = new List<int>();
            result = Add(p1, p2);
            Console.WriteLine("p1 + p2 = {0}X^2 + {1}X + {2}", result[0],result[1],result[2]);
        }

        private static List<int> Add(List<int> p1, List<int> p2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < p1.Count; i++)
            {
                result.Add(p1[i] + p2[i]);
            }
            return result;
        }
    }
}
