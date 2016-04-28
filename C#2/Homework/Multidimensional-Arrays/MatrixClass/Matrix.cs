using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class Matrix
    {
        int[,] matrix;

        // default constructor
        public Matrix()
        {
            matrix = new int[0, 0];
        }

        // create rows x cols matrix
        public Matrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
        }

        //create matrix with data passed to this constructor
        public Matrix(int[,] matrix) 
        {
            this.matrix = matrix;
        }

        // indexer
        public int this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
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
                return result;
            }
            return null;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            if ((first.GetLength(0) == second.GetLength(0)) &&
                (first.GetLength(1) == second.GetLength(1)))
            {
                Matrix result = new Matrix(first.GetLength(0), first.GetLength(1));

                for (int row = 0; row < first.GetLength(0); row++)
                {
                    for (int col = 0; col < first.GetLength(1); col++)
                    {
                        result[row, col] = first[row, col] - second[row, col];
                    }
                }
                return result;
            }
            return null;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.GetLength(1) == second.GetLength(0))
            {
                Matrix result = new Matrix(first.GetLength(1), second.GetLength(0));

                for (int row = 0; row < first.GetLength(1); row++)
                {
                    for (int col = 0; col < second.GetLength(0); col++)
                    {
                        int res = 0;
                        for (int element = 0; element < first.GetLength(1); element++)
                        {
                            res += first[row, element] * second[element, col];
                        }
                        result[row, col] = res;
                    }
                }
                return result;
            }
            return null;
        }

        public override string ToString()
        {
            String result = string.Empty;
            List<int> rowItems = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    rowItems.Add(matrix[row, col]);
                }
                result += String.Join(", ", rowItems) + "\n";
                rowItems.Clear();
            }
            return result.ToString();
        }
    }
}
