//  Problem 19.** Spiral Matrix
//  
//      Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//      and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//  
//  Examples:
//  
//  n = 2   matrix      n = 3   matrix      n = 4   matrix
//          1 2                 1 2 3               1  2  3  4
//          4 3                 8 9 4               12 13 14 5
//                              7 6 5               11 16 15 6
//                                                  10 9  8  7


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("enter integer number (1 <= n <= 20) n= ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<int> elements = Enumerable.Range(1, number * number).ToList();
            int[,] matrix = new int[number, number];
            int row = 0, topBoundary = 1, bottomBoundary = number, col = -1, leftBoundary = 0, rightBoundary = number, elementCounter = 0;

            //for all elements
            while (elementCounter < elements.Count)
            {
                // if there is elements move right until the boundary
                if (elementCounter < elements.Count)
                    do
                    {
                        col++;
                        matrix[row, col] = elements[elementCounter];
                        elementCounter++;
                    }
                    while (col < rightBoundary - 1);
                rightBoundary--;

                // if there is elements move down until the boundary
                if (elementCounter < elements.Count)
                    do
                    {
                        row++;
                        matrix[row, col] = elements[elementCounter];
                        elementCounter++;
                    }
                    while (row < bottomBoundary - 1);
                bottomBoundary--;

                // if there is elements move left until the boundary
                if (elementCounter < elements.Count)
                    do
                    {
                        col--;
                        matrix[row, col] = elements[elementCounter];
                        elementCounter++;
                    }
                    while (col > leftBoundary);
                leftBoundary++;

                // if there is elements move up until the boundary
                if (elementCounter < elements.Count)
                    do
                    {
                        row--;
                        matrix[row, col] = elements[elementCounter];
                        elementCounter++;
                    }
                    while (row >= topBoundary + 1);
                topBoundary++;
            }

            Print(matrix, number);
        }

        private static void Print(int[,] matrix, int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(" {0,3}", matrix[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
