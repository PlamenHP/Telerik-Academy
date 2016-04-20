//  Problem 1. Fill the matrix
//  
//      Write a program that fills and prints a matrix of size (n, n) as shown below:
//  
//  Example for n=4:
//  a) 	              b)             c) 		     d)*		 
//  1	5	9	13    1  8	9	16   7	11	14	16   1	12	11	10
//  2	6	10	14    2	 7	10	15   4	8	12	15   2	13	16	9
//  3	7	11	15    3  6	11	14   2	5	9	13   3	14	15	8
//  4	8	12	16    4	 5	12	13   1	3	6	10   4	5	6	7

namespace Namespace
{
    using System;
    class FillTheMatrix
    {
        static void Main()
        {
            Console.WriteLine("Problem 1. Fill the matrix \n");
            Console.Write("enter the matrix(n, n) size n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("A)");
            PrintA(n);
            Console.WriteLine("B)");
            PrintB(n);
            Console.WriteLine("C)");
            PrintC(n);
            Console.WriteLine("D)");
            PrintD(n);
        }

        private static void Print(int[,] data)
        {
            for (int row = 0; row < data.GetLength(0); row++)
            {
                for (int col = 0; col < data.GetLength(0); col++)
                {
                    Console.Write("{0,3}", data[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        private static void PrintA(int n)
        {
            int[,] data = new int[n, n];
            int counter = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    counter++;
                    data[col, row] = counter;
                }
            }
            Print(data);
        }

        private static void PrintB(int n)
        {
            int[,] data = new int[n, n];
            int counter = 0;

            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < n; col++)
                    {
                        counter++;
                        data[col, row] = counter;
                    }
                }
                else
                {
                    for (int col = n - 1; col >= 0; col--)
                    {
                        counter++;
                        data[col, row] = counter;
                    }
                }
            }
            Print(data);
        }

        private static void PrintC(int n)
        {
            int[,] data = new int[n, n];
            int totalItems = n * n;
            int counter = 0;
            int indexRow = n-1;
            int indexCol = 0;
            int row = indexRow;
            int col = indexCol;

            while (counter < totalItems)
            {
                do
                {
                    counter++;
                    data[row, col] = counter;
                    row++;
                    col++;
                }
                while (row < n && col < n);

                if (indexRow==0 && indexCol < n-1)
                    indexCol++;
                if (indexRow > 0)
                    indexRow--;
                row = indexRow;
                col = indexCol;
            }
            Print(data);
        }

        private static void PrintD(int n)
        {
            int[,] data = new int[n, n];
            int totalItems = n * n;
            int counter = 0;
            int row = -1;
            int col = 0;
            int boundaryLeft = 0;
            int boundaryRight = n -1;
            int boundaryTop = 0;
            int boundaryBottom = n -1;

            while (counter < totalItems)
            {
                do
                {//go down
                    counter++;
                    row++;
                    data[row, col] = counter;
                } while (row < boundaryBottom);
                boundaryLeft++;
                if (counter == totalItems) break;

                do
                {//go right
                    counter++;
                    col++;
                    data[row, col] = counter;
                } while (col < boundaryRight);
                boundaryBottom--;
                if (counter == totalItems) break;

                do
                {//go up
                    counter++;
                    row--;
                    data[row, col] = counter;
                } while (row > boundaryTop);
                boundaryRight--;
                if (counter == totalItems) break;

                do
                {//go left
                    counter++;
                    col--;
                    data[row, col] = counter;
                } while (col > boundaryLeft);
                boundaryTop++;
                if (counter == totalItems) break;
            }
            Print(data);
        }
    }
}
