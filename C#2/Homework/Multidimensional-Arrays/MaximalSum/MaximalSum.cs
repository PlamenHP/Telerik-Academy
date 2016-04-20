//  Problem 2. Maximal sum
//  
//      Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
//      that has maximal sum of its elements.


namespace Namespace
{
    using System;
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("Problem 2. Maximal sum \n");
            Console.Write("enter rows count (N>=3) N= ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("enter columns count (M>=3) M= ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            String inputNumber;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    inputNumber = Console.ReadLine();
                    matrix[row, column] = int.Parse(inputNumber);
                }
            }

            if (rows > 2 && columns > 2)
            {
                int[,] maxSumSquare = FindMaxSumSquare(matrix);
                Print(matrix, maxSumSquare);
            }
        }

        private static void Print(int[,] data,int[,] result)
        {

            Console.WriteLine("\n Input matrix\n");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0,3}", data[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Result \n");
            int maxSum = 0;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write("{0,3}", result[i, j]);
                    maxSum += result[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("maximal sum = {0} ", maxSum);
        }

        private static int[,] FindMaxSumSquare(int[,] data)
        {
            int[,] maxSumSquare = new int[3, 3];
            int maxRow = 0;
            int maxCol = 0;
            int maxSum = 0;
            int sum = 0;

            for (int row = 0; row < data.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < data.GetLength(1) - 2; col++)
                {
                    sum = GetSum(data, row, col);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            for (int row = 0; row < 3 ; row++)
            {
                for (int col = 0 ; col < 3; col++)
                {
                    maxSumSquare[row, col] = data[row+ maxRow, col+  maxCol];
                }
            }

            return maxSumSquare;
        }

        private static int GetSum(int[,] data, int sumRow, int sumCol)
        {
            int sum = 0;

            for (int row = sumRow; row < 3+sumRow; row++)
            {
                for (int col = sumCol; col < 3+sumCol; col++)
                {
                    sum += data[row, col];
                }
            }

            return sum;
        }
    }
}
