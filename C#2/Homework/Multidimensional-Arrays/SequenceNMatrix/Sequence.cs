using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class Sequence
    {
        private static List<string> max = new List<string>();
        private static List<string> current = new List<string>();
        private static string[,] data = new string[0, 0];
        int numRows = 0;
        int numCols = 0;

        public Sequence(string[,] input)
        {
            data = input;
            numRows = data.GetLength(0);
            numCols = data.GetLength(1);
        }

        public List<string> GetLongestSequence()
        {
            CheckHorizontal();
            CheckVertical();
            CheckRightDiagonal();
            CheckLeftDiagonal();
            return max;
        }

        private void CheckHorizontal()
        {

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    CheckElement(row, col);
                }
                current.Clear();
            }
        }

        private void CheckVertical()
        {
            for (int col = 0; col < numCols; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    CheckElement(row, col);
                }
                current.Clear();
            }
        }

        private void CheckRightDiagonal()
        {
            int indexRow = numRows - 1;
            int indexCol = 0;
            int row = indexRow;
            int col = indexCol;

            while ((indexRow >= 0) && (indexCol < numCols))
            {
                do
                {
                    CheckElement(row, col);
                    row++;
                    col++;
                } while (row < numRows && col < numCols);

                if (indexRow > 0) indexRow--;
                else indexCol++;

                row = indexRow;
                col = indexCol;
            }
        }

        private void CheckLeftDiagonal()
        {
            int indexRow = 0;
            int indexCol = 0;
            int row = indexRow;
            int col = indexCol;

            while (indexRow < numRows && indexCol < numCols)
            {
                do
                {
                    CheckElement(row, col);
                    row++;
                    col--;
                } while (row < numRows && col >= 0);

                if (indexCol < numCols - 1) indexCol++;
                else indexRow++;

                row = indexRow;
                col = indexCol;
            }
        }

        private void CheckElement(int row, int col)
        {
            if (current.Count == 0)
            {
                current.Add(data[row, col]);
            }
            else if (current.Last() == data[row, col])
            {
                current.Add(data[row, col]);

                if (current.Count > max.Count)
                {
                    max = new List<string>(current);
                }
            }
            else
            {
                current.Clear();
                current.Add(data[row, col]);
            }
        }
    }
}
