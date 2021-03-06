﻿//  Problem 3. Sequence n matrix
//  
//      We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//      as sets of several neighbour elements located on the same line, column or diagonal.
//      Write a program that finds the longest sequence of equal strings in the matrix.
//  
//  Example:
//
//  matrix  	        result 		    matrix 	    result
//  ha	fifi  ho  hi    ha, ha, ha     s	qq	s   s, s, s
//  fo	ha	  hi  xx                   pp	pp	s
//  xxx	ho	  ha  xx                   pp	qq	s


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SequenceNMatrix
    {
        static void Main()
        {
            Console.WriteLine("Problem 3. Sequence n matrix \n");
            Console.Write("enter rows count (N>=3) N= ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("enter columns count (M>=3) M= "); Console.WriteLine();
            int columns = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, columns];
            string input = string.Empty;

            Console.WriteLine("Enter strings elements");
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    input = Console.ReadLine();
                    matrix[row, column] = input;
                }
            }

            Print(matrix);

            Sequence sec = new Sequence(matrix);
            List<string> result = sec.GetLongestSequence();

            Console.WriteLine("result:");
            Console.WriteLine(String.Join(", ", result));
        }

        private static void Print(string[,] data)
        {
            for (int row = 0; row < data.GetLength(0); row++)
            {
                for (int column = 0; column < data.GetLength(1); column++)
                {
                    Console.Write("[{0,4}] ", data[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
