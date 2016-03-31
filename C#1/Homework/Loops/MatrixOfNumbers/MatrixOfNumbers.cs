//  Problem 9. Matrix of Numbers
//  
//      Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//      and prints a matrix like in the examples below. Use two nested loops.
//  
//  Examples:
//  
//  n = 2   matrix      n = 3   matrix      n = 4   matrix
//          1 2                 1 2 3               1 2 3 4
//          2 3                 2 3 4               2 3 4 5
//                              3 4 5               3 4 5 6
//                                                  4 5 6 7
//  

namespace Namespace
{
    using System;
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("enter integer number (1 ≤ n ≤ 20) n= ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < row + n; col++)
                {
                    Console.Write("{0} ",col);
                }
                Console.WriteLine();
            }
        }
    }
}
