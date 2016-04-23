using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class Matrix
    {
        int[,] matrix;

        public Matrix(int row, int col)
        {
            matrix = new int[row, col];
        }

        public int this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
        }

        public int GetLength(int dimention)
        {
            if (dimention == 0)
            {
                return matrix.GetLength(0);
            }
            else if (dimention == 1)
            {
                return matrix.GetLength(1);
            }
            else
            {
                return -1;
            }
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            if ((first.GetLength(0) == second.GetLength(0)) &&
                (first.GetLength(1) == second.GetLength(1)))
            {
                Matrix result = new Matrix(first.GetLength(0), first.GetLength(1));
                for (int row = 0; row < first.GetLength(0); row++)
                {
                    for (int col = 0; col < first.GetLength(1); col++)
                    {
                        result[row, col] = first[row, col] + second[row, col];
                    }
                }
            }
            return new Matrix();
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            return new Matrix();
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            return new Matrix();
        }

        public override string ToString()
        {
            return "";
        }
    }
}
