

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SubtractingPolynomials
    {
        static void Main()
        {
            List<int> result = new List<int>();
            List<int> p1 = new List<int> { 5, 0, 1 };
            List<int> p2 = new List<int> { 5, -3, 1 };
            Console.WriteLine("p1 = {0}X^2 + {1}X + {2}       p2 = {3}X^2 + {4}X + {5}", p1[0], p1[1], p1[2], p2[0], p2[1], p2[2]);


            result = Add(p1, p2);
            Console.WriteLine("p1 + p2 = {0}", FormatPolinomial(result));

            result = Substract(p1, p2);
            Console.WriteLine("p1 - p2 = {0}", FormatPolinomial(result));

            result = Multiply(p1, p2);
            Console.WriteLine("p1 * p2 = {0}", FormatPolinomial(result));
        }

        private static string FormatPolinomial(List<int> p)
        {
            return String.Format("{0}{1}X^2 {2} {3}X {4} {5}", p[0] < 0 ? "-" : "", Math.Abs(p[0]), p[1] < 0 ? "-" : "+", Math.Abs(p[1]), p[2] < 0 ? "-" : "+", Math.Abs(p[2]));
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

        private static List<int> Substract(List<int> p1, List<int> p2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < p1.Count; i++)
            {
                result.Add(p1[i] - p2[i]);
            }
            return result;
        }

        private static List<int> Multiply(List<int> p1, List<int> p2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < p1.Count; i++)
            {
                result.Add(p1[i] * p2[i]);
            }
            return result;
        }
    }
}

