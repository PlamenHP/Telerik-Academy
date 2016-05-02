//  Problem 15.* Number calculations
//  
//      Modify your last program and try to make it work for any number type,
//      not just integer(e.g. decimal, float, byte, etc.)
//      Use generic method(read in Internet about generic methods in C#).


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NumberCalculations
    {
        static void Main()
        {
            // integers
            var data1 = new List<int> { 1, 2, 3 };
            var data11 = new List<int> { 4, 5, 6, 7 };
            //strings
            var data2 = new List<string> { "A", "B", "C" };
            var data22 = new List<string> { "D", "E", "F", "G" };
            //doubles
            var data3 = new List<double> { 7.1, 8.1, 9.1 };
            var data33 = new List<double> { 4.2, 2.7, 8.6, 6.1 };
            // print lists
            Console.WriteLine("data1: {0}", String.Join(", ", data1));
            Console.WriteLine("data11: {0}\n", String.Join(", ", data11));
            Console.WriteLine("data2: {0}", String.Join(", ", data2));
            Console.WriteLine("data22: {0}\n", String.Join(", ", data22));
            Console.WriteLine("data3: {0}", String.Join(", ", data3));
            Console.WriteLine("data33: {0}", String.Join(", ", data33));

            var minimums1 = new List<int>(Minimums(data1, data11));
            Console.WriteLine("\nMinimums: {0}", String.Join(", ", minimums1));
            var minimums2 = new List<string>(Minimums(data2, data22));
            Console.WriteLine("Minimums: {0}", String.Join(", ", minimums2));
            var minimums3 = new List<double>(Minimums(data3, data33));
            Console.WriteLine("Minimums: {0}", String.Join(", ", minimums3));

            var maximums1 = new List<int>(Maximums(data1, data11));
            Console.WriteLine("\nMaximums: {0}", String.Join(", ", maximums1));
            var maximums2 = new List<string>(Maximums(data2, data22));
            Console.WriteLine("Maximums: {0}", String.Join(", ", maximums2));
            var maximums3 = new List<double>(Maximums(data3, data33));
            Console.WriteLine("Maximums: {0}", String.Join(", ", maximums3));

            var averages1 = new List<int>(Averages(data1, data11));
            Console.WriteLine("\nAverages: {0}", String.Join(", ", averages1));
            var averages3 = new List<double>(Averages(data3, data33));
            Console.WriteLine("Averages: {0}", String.Join(", ", averages3));

            var sums1 = new List<int>(Sums(data1, data11));
            Console.WriteLine("\nSums: {0}", String.Join(", ", sums1));
            var sums2 = new List<string>(Sums(data2, data22));
            Console.WriteLine("Sums: {0}", String.Join(", ", sums2));
            var sums3 = new List<double>(Sums(data3, data33));
            Console.WriteLine("Sums: {0}", String.Join(", ", sums3));

            var products1 = new List<int>(Products(data1,data11));
            Console.WriteLine("\nProducts: {0}", String.Join(", ", products1));
            var products3 = new List<double>(Products(data3, data33));
            Console.WriteLine("Products: {0}", String.Join(", ", products3));
        }

        private static List<T> Minimums<T>(params IList<T>[] list) where T : IComparable
        {
            var minimums = new List<T>();

            for (int i = 0; i < list.Length; i++)
            {
                minimums.Add(Minimum(list[i]));
            }
            return minimums;
        }

        private static T Minimum<T>(IList<T> data) where T : IComparable
        {
            var minimum = data[0];

            for (int i = 1; i < data.Count; i++)
            {
                if (data[i].CompareTo(minimum) < 0)
                {
                    data[i] = minimum;
                    minimum = data[i];
                }
            }
            return minimum;
        }

        private static List<T> Maximums<T>(params IList<T>[] list) where T: IComparable
        {
            var maximums = new List<T>();

            for (int i = 0; i < list.Length; i++)
            {
                maximums.Add(Maximum(list[i]));
            }
            return maximums;
        }

        private static T Maximum<T>(IList<T> data) where T : IComparable
        {
            T maximum = data[0];

            for (int i = 1; i < data.Count; i++)
            {
                if (data[i].CompareTo(maximum) > 0)
                {
                    maximum = data[i];
                }
            }
            return maximum;
        }

        private static IList<T> Averages<T>(params IList<T>[] list) where T : struct, IComparable
        {
            var averages = new List<T>();

            for (int i = 0; i < list.Length; i++)
            {
                averages.Add(Average(list[i]));
            }
            return averages;
        }

        private static T Average<T>(IList<T> data) where T : struct, IComparable
        {
            var average = (dynamic)Sum((IList<T>)data) / data.Count;
            return average;
        }

        private static IList<T> Sums<T>(params IList<T>[] list) where T : IComparable
        {
            var sums = new List<T>();

            for (int i = 0; i < list.Length; i++)
            {
                sums.Add(Sum(list[i]));
            }
            return sums;
        }

        private static T Sum<T>(IList<T> data) where T : IComparable
        {
            var sum = data[0];

            for (int i = 1; i < data.Count; i++)
            {
                sum = (dynamic)sum + data[i];
            }
            return sum;
        }

        private static IList<T> Products<T>(params IList<T>[] list) where T : struct, IComparable
        {
            var products = new List<T>();

            for (int i = 0; i < list.Length; i++)
            {
                products.Add(Product(list[i]));
            }
            return products;
        }

        private static T Product<T>(IList<T> data) where T: struct, IComparable
        {
            var product = data[0];

            for (int i = 1; i < data.Count; i++)
            {
                product = (dynamic)product * data[i];
            }
            return product;
        }
    }
}

