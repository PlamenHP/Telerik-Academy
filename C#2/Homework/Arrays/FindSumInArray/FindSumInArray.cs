//  Problem 10. Find sum in array
//  
//      Write a program that finds in given array of integers a sequence of given sum S (if present).
//  
//  Example:
//  array 	                S 	    result
//  4, 3, 1, 4, 2, 5, 8 	11  	4, 2, 5

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class FindSumInArray
    {
        static void Main()
        {
            Console.WriteLine("Problem 10. Find sum in array\n");
            Console.WriteLine("Enter a sequence in the format: 4, 3, 1, 4, 2, 5, 8");
            List<int> data = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries).Select(x => int.Parse(x))
                .ToList();

            Console.WriteLine("Enter a number for sum S= ");
            int sum = int.Parse(Console.ReadLine());
            int resultFromIndex = 0, resultToIndex = 0;

            FindSum(data, sum, out resultFromIndex, out resultToIndex);

            List<int> result = new List<int>(data.GetRange(resultFromIndex, resultToIndex - resultFromIndex + 1));
            Console.WriteLine(string.Join(", ", result));
        }

        private static void FindSum(List<int> data, int sum, out int resultFromIndex, out int resultToIndex)
        {
            int tempFromIndex = 0, tempData = 0;
            resultFromIndex = 0;
            resultToIndex = 0;

            for (int i = 0; i < data.Count; i++)
            {
                tempData += data[i];

                while (tempData > sum)
                {
                    tempData -= data[tempFromIndex];
                    tempFromIndex++;
                }

                if (tempData == sum)
                {
                    resultFromIndex = tempFromIndex;
                    resultToIndex = i;
                    break;
                }
            }
        }
    }
}
