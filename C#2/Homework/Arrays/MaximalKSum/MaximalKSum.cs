//  Problem 6. Maximal K sum
//  
//      Write a program that reads two integer numbers N and K and an array of N elements from the console.
//      Find in the array those K elements that have maximal sum.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MaximalKSum
    {
        static void Main()
        {
            Console.WriteLine("Problem 6. Maximal K sum\n");
            Console.Write("Enter integer number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter integer number k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array:");
            List<int> array = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("element[{0}]=", i);
                array.Add(int.Parse(Console.ReadLine()));
            }
            string result = string.Join(", ",FindMaximalKSum(array, k));
            Print(result);
        }

        private static List<int> FindMaximalKSum(List<int> array, int k)
        {
            List<int> max = Enumerable.Repeat(0, k).ToList();
            int minIndex=0;

            for (int i = 0; i < array.Count; i++)
            {
                minIndex = max.IndexOf(max.Min(x=>x));

                if (array[i] > max[minIndex])
                {
                    max[minIndex] = array[i];
                }
            }
            return max;
        }

        private static void Print(string result)
        {
            Console.WriteLine(result);
        }
    }
}
