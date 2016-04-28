//   Problem 6.* Matrix class
//  
//      Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, 
//      subtracting and multiplying of matrices, indexer for accessing the matrix content
//      and ToString().

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MatrixClass
    {
        static void Main()
        {

            Matrix m1 = new Matrix(new[,]
             {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            });

            Matrix m2 = new Matrix(new[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            });

            Console.WriteLine("Matrix-1:\n{0}", m1.ToString());
            Console.WriteLine("Matrix-2:\n{0}",m2.ToString());

            Matrix matrix = new Matrix(3, 3);
            matrix = m1 * m2;
            Console.WriteLine("Matrix-1 * Matrix-2 =\n{0}", matrix.ToString());

            matrix = m1 + m2;
            Console.WriteLine("Matrix-1 + Matrix-2 =\n{0}", matrix.ToString());

            matrix = m1 - m2;
            Console.WriteLine("Matrix-1 = Matrix-2 =\n{0}", matrix.ToString());
        }
    }
}
