using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class LargestSequenceArea
    {
        int[,] matrix = new int[0, 0];
        bool[,] visited = new bool[0, 0];
        int rows = 0;
        int cols = 0;
        int maxCount = 0;
        int currentCount = 0;

        public LargestSequenceArea(int[,] matrix)
        {
            this.matrix = matrix;
            this.rows = matrix.GetLength(0);
            this.cols = matrix.GetLength(1);
            this.visited = new bool[rows, cols];
        }

        public int GetCount()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (visited[row, col] != true)
                    {
                        Bfs(row, col);
                    }
                }
            }
            return maxCount;
        }

        private void Bfs(int parentRow, int parentCol)
        {
            Queue<int[]> queue = new Queue<int[]>();
            visited[parentRow, parentCol] = true;

            queue.Enqueue(new int[] { parentRow, parentCol });
            currentCount = 0;

            while (queue.Count > 0)
            {
                int[] parentElement = queue.Dequeue();
                parentRow = parentElement[0];
                parentCol = parentElement[1];
                currentCount++;

                // iterate neighbor elements and enqueue matching/children elements
                for (int row = parentRow - 1; row <= parentRow + 1; row++)
                {
                    for (int col = parentCol - 1; col <= parentCol + 1; col++)
                    {
                        if (row >= 0 && row < rows && col >= 0 && col < cols)
                        {
                            if (!visited[row, col])
                            {
                                if (matrix[row, col] == matrix[parentRow, parentCol])
                                {
                                    visited[row, col] = true;
                                    queue.Enqueue(new int[] { row, col });
                                }
                            }
                        }
                    }
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
        }
    }
}
