//  Problem 8. Maximal sum
//  
//      Write a program that finds the sequence of maximal sum in given array.
//  
//  Example:
//  input 	                            result
//  2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("Problem 4. Maximal sequence\n");
            Console.WriteLine("Enter a sequence in the format: 2, 3, -6, -1, 2, -1, 6, 4, -8, 8");
            List<int> data = Console.ReadLine()
                .Split(new string[]{", "}, StringSplitOptions
                .RemoveEmptyEntries).Select(x=>int.Parse(x))
                .ToList();
            int max1=0, max2 = 0;

            FindMaxSum(data,out max1,out max2);

            List<int> result = new List<int>(data.GetRange(max1,max2-max1+1));
            Console.WriteLine(string.Join(", ", result));
        }

        private static void FindMaxSum(List<int> data, out int resultFromIndex, out int resultToIndex)
        {
            int resultData = 0, tempFromIndex = 0, tempData = 0;
            resultFromIndex = 0;
            resultToIndex = 0;
            for (int i = 0; i < data.Count; i++)
            {
                tempData += data[i];

                if (tempData > resultData)
                {
                    resultFromIndex = tempFromIndex;
                    resultToIndex = i;
                    resultData = tempData;
                }

                if (tempData <= 0)
                {
                    tempFromIndex = i + 1;
                    tempData = 0;
                }
            }
        }
    }
}
