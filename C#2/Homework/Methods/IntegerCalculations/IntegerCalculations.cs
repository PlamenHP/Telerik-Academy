//  Problem 14. Integer calculations
//  
//      Write methods to calculate minimum, maximum, average, sum 
//      and product of given set of integer numbers.
//      Use variable number of arguments.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class IntegerCalculations
    {
        private static object minimums;

        static void Main()
        {
            List<int> data1 = new List<int> { 1, 2, 3 };
            List<int> data2 = new List<int> { 4, 5, 6 };
            List<int> data3 = new List<int> { 7, 8, 9 };
            Console.WriteLine("data1: {0}", String.Join(", ", data1));
            Console.WriteLine("data2: {0}", String.Join(", ", data2));
            Console.WriteLine("data3: {0}", String.Join(", ", data3));


            List<int> minimums = new List<int>(Minimums(data1, data2, data3));
            Console.WriteLine("\nMinimums: {0}", String.Join(", ", minimums));

            List<int> maximums = new List<int>(Maximums(data1, data2, data3));
            Console.WriteLine("\nMaximums: {0}", String.Join(", ", maximums));

            List<decimal> averages = new List<decimal>(Averages(data1, data2, data3));
            Console.WriteLine("\nAverages: {0}", String.Join(", ", averages));

            List<int> sums = new List<int>(Sums(data1, data2, data3));
            Console.WriteLine("\nSums: {0}", String.Join(", ", sums));

            List<int> products = new List<int>(Products(data1, data2, data3));
            Console.WriteLine("\nProducts: {0}", String.Join(", ", products));
        }

        private static List<int> Minimums(params List<int>[] list)
        {
            List<int> minimums = new List<int>();

            for (int i = 0; i < list.Length; i++)
            {
                minimums.Add(Minimum(list[i]));
            }
            return minimums;
        }

        private static int Minimum(List<int> data)
        {
            int minimum = data[0];

            for (int i = 1; i < data.Count; i++)
            {
                if (data[i] < minimum)
                {
                    minimum = data[i];
                }
            }
            return minimum;
        }

        private static List<int> Maximums(params List<int>[] list)
        {
            List<int> maximums = new List<int>();

            for (int i = 0; i < list.Length; i++)
            {
                maximums.Add(Maximum(list[i]));
            }
            return maximums;
        }

        private static int Maximum(List<int> data)
        {
            int maximum = data[0];

            for (int i = 1; i < data.Count; i++)
            {
                if (data[i] > maximum)
                {
                    maximum = data[i];
                }
            }

            return maximum;
        }

        private static List<decimal> Averages(params List<int>[] list)
        {
            List<decimal> averages = new List<decimal>();

            for (int i = 0; i < list.Length; i++)
            {
                averages.Add(Average(list[i]));
            }
            return averages;
        }

        private static decimal Average(List<int> data)
        {
            decimal average = (decimal)Sum(data) / data.Count;
            return average;
        }

        private static List<int> Sums(params List<int>[] list)
        {
            List<int> sums = new List<int>();

            for (int i = 0; i < list.Length; i++)
            {
                sums.Add(Sum(list[i]));
            }
            return sums;
        }

        private static int Sum(List<int> data)
        {
            int sum = 0;

            for (int i = 0; i < data.Count; i++)
            {
                sum = sum + data[i];
            }
            return sum;
        }

        private static List<int> Products(params List<int>[] list)
        {
            List<int> products = new List<int>();

            for (int i = 0; i < list.Length; i++)
            {
                products.Add(Product(list[i]));
            }
            return products;
        }

        private static int Product(List<int> data)
        {
            int product = 1;

            for (int i = 0; i < data.Count; i++)
            {
                product = product * data[i];
            }
            return product;
        }
    }
}
