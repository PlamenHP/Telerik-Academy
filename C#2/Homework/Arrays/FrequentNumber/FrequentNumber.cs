using FrequentNumber;
//  Problem 9. Frequent number
//  
//      Write a program that finds the most frequent number in an array.
//  
//  Example:
//  input 	result
//  4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class FrequentNumber
    {
        static void Main()
        {
            Console.WriteLine("Problem 9. Frequent number\n");
            Console.WriteLine("Enter a sequence in the format: 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3");
            List<int> data = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries).Select(x => int.Parse(x))
                .ToList();
            int number = 0, count = 0;

            FindFrequentNumber(data, out number, out count);

            Console.WriteLine("{0} ({1} times)", number, count);
        }

        private static void FindFrequentNumber(List<int> data, out int resultNumber, out int count)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int number in data)
            {
                if (dic.Keys.Contains(number))
                    dic[number]++;
                else
                    dic.Add(number, 1);
            }

            resultNumber = dic.FirstOrDefault(x => x.Value == dic.Values.Max()).Key;
            count = dic.FirstOrDefault(x => x.Value == dic.Values.Max()).Value;
        }
    }
}
