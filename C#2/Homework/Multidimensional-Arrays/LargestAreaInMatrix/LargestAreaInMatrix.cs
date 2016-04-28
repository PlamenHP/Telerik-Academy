//  Problem 7.* Largest area in matrix
//  
//      Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
//  
//  Example:
//          matrix                  result
//  1	3	2	2	2	4             13
//  3	3	3	2	4	4
//  4	3	1	2	3	3
//  4	3	1	3	3	1
//  4	3	3	3	1	1
//  	

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LargestAreaInMatrix
    {
        static void Main()
        {
            int[,] matrix = new int[,]
            {
                {1, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1}
            };

            LargestSequenceArea LargestSequenceInMatrix = new LargestSequenceArea(matrix);
            int result = LargestSequenceInMatrix.GetCount();


            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(" {0} ",matrix[row,col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Largest area elements count = {0}", result);
        }
    }
}
