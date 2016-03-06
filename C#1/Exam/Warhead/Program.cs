using System;

namespace Warhead
{
    class Warhead
    {
        public static int[,] board = new int[16, 16];

        static void Main()
        {

            for (int i = 0; i < 16; i++)
            {
                string rowtext = Console.ReadLine();
                for (int j = 0; j < 16; j++)
                {
                    board[i, j] = rowtext[j] - '0';
                }
            }

            while (true)
            {
                string currentOperation = Console.ReadLine();

                if (currentOperation == "hover" || currentOperation == "operate")
                {
                    int currentRow = int.Parse(Console.ReadLine());
                    int currentCol = int.Parse(Console.ReadLine());

                    if (currentOperation == "hover")
                    {
                        if (board[currentRow, currentCol] == 1)
                        {
                            Console.WriteLine('*');
                            continue;
                        }
                        else
                        {
                            Console.WriteLine('-');
                            continue;
                        }
                    }

                    if (currentOperation == "operate")
                    {
                        int currentNumber = board[currentRow, currentCol];

                        if (currentNumber == 1)
                        {
                            int shapesCount = RedShapesCount() + BlueShapesCount();

                            Console.WriteLine("missed");
                            Console.WriteLine(shapesCount);
                            Console.WriteLine("BOOM");
                            break;
                        }
                        else
                        {
                            if (IsItFigure(currentRow, currentCol))
                            {
                                ClearFigure(currentRow, currentCol);
                            }
                            continue;
                        }
                    }
                }

                if (currentOperation == "cut")
                {
                    string wireColor = Console.ReadLine();

                    if (wireColor == "red")
                    {
                        if (RedShapesCount() == 0)
                        {
                            Console.WriteLine(BlueShapesCount());
                            Console.WriteLine("disarmed");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(RedShapesCount());
                            Console.WriteLine("BOOM");
                            break;
                        }
                    }
                    else
                    {
                        if (BlueShapesCount() == 0)
                        {
                            Console.WriteLine(RedShapesCount());
                            Console.WriteLine("disarmed");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(BlueShapesCount());
                            Console.WriteLine("BOOM");
                            break;
                        }
                    }
                }
            }
        }

        public static bool IsItFigure(int row, int col)
        {
           // bool rowInLimit = (0 < row) && (row < 15);
           // bool colRedInLimit = (0 < col) && (col < 7);
           // bool colBlueInLimit = (8 < col) && (col < 15);
            bool rowInLimit = (0 < row) && (row < 15);
            bool colInLimit = (0 < col) && (col < 15);

            //if (rowInLimit && (colRedInLimit || colBlueInLimit))
            if (rowInLimit && colInLimit)
            {
                if ((board[row - 1, col - 1] == 1) && (board[row - 1, col] == 1) && (board[row - 1, col + 1] == 1) &&
                    (board[row, col - 1] == 1) && (board[row, col + 1] == 1) &&
                    (board[row + 1, col - 1] == 1) && (board[row + 1, col] == 1) && (board[row + 1, col + 1] == 1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void ClearFigure(int row, int col)
        {
            board[row - 1, col - 1] = 0;
            board[row - 1, col] = 0;
            board[row - 1, col + 1] = 0;
            board[row, col - 1] = 0;
            board[row, col + 1] = 0;
            board[row + 1, col - 1] = 0;
            board[row + 1, col] = 0;
            board[row + 1, col + 1] = 0;
        }

        public static int RedShapesCount()
        {
            int redShapesCount = 0;

            for (int row = 1; row < 15; row++)
            {
                for (int col = 1; col < 8; col++)
                {
                    if (IsItFigure(row, col))
                    {
                        redShapesCount++;
                    }
                }
            }
            return redShapesCount;
        }

        public static int BlueShapesCount()
        {
            int blueShapesCount = 0;

            for (int row = 1; row < 15; row++)
            {
                for (int col = 8; col < 15; col++)
                {
                    if (IsItFigure(row, col))
                    {
                        blueShapesCount++;
                    }
                }
            }
            return blueShapesCount;
        }
    }
}
