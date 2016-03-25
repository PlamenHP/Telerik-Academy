

namespace Snake
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    class Snake
    {
        struct Position
        {
            public int row;
            public int col;
            public Position(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }

        static void Main()
        {
            byte right = 0;
            byte left = 1;
            byte down = 2;
            byte up = 3;
            int lastFoodTime = 0;
            int foodDissapearTime = 8000;
            double negativePoints = 0;
            int userPoints = 0;

            Position[] directions = new Position[]
            {
                new Position(0,1), //right
                new Position(0,-1), //left
                new Position(1,0), //down
                new Position(-1,0), //up
            };
            double sleepTime = 100;
            int direction = right;
            Console.BufferHeight = Console.WindowHeight;
            Random randomNumberGenerator = new Random();
            Console.CursorVisible = false;

            // create new snake
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            // show the snake
            foreach (var position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
            }


            List<Position> obstacles = new List<Position>()
            {
                new Position(12, 12),
                new Position(14,20),
                new Position(7,7)
            };

            foreach (var obstacle in obstacles)
            {
                Console.SetCursorPosition(obstacle.col, obstacle.row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("!");
            }

            // create new food
            Position food;
            do
            {
                //create new food
                food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight),
                    randomNumberGenerator.Next(0, Console.WindowWidth));
            }
            while (snakeElements.Contains(food) || obstacles.Contains(food));
            lastFoodTime = Environment.TickCount;

            Console.SetCursorPosition(food.col, food.row);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("@");


            while (true)
            {
                negativePoints+= 0.1;
                // Getting user input
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (direction != right) direction = left;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (direction != left) direction = right;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (direction != down) direction = up;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        if (direction != up) direction = down;
                    }
                }

                Position nextDirection = directions[direction];
                Position snakeHead = snakeElements.Last();
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);

                if (snakeNewHead.col < 0) snakeNewHead.col = Console.WindowWidth - 1;
                if (snakeNewHead.row < 0) snakeNewHead.row = Console.WindowHeight - 1;
                if (snakeNewHead.col >= Console.WindowWidth) snakeNewHead.col = 0;
                if (snakeNewHead.row >= Console.WindowHeight) snakeNewHead.row = 0;

                if (snakeElements.Contains(snakeNewHead) || obstacles.Contains(snakeNewHead))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over!");
                    userPoints = (snakeElements.Count - 6) * 100 - (int)negativePoints;
                    userPoints = Math.Max(userPoints, 0);
                    Console.WriteLine("Your points are: {0}", userPoints);
                    return;
                }

                // moving, adding snake new head
                Console.SetCursorPosition(snakeHead.col, snakeHead.row);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
                snakeElements.Enqueue(snakeNewHead);
                Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                Console.ForegroundColor = ConsoleColor.Green;
                if (direction == right) Console.Write(">");
                if (direction == left) Console.Write("<");
                if (direction == up) Console.Write("^");
                if (direction == down) Console.Write("v");

                // snake next move food detection
                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                {
                    // feeding, not removing the last snake element
                    do
                    {
                        //create new food
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight),
                            randomNumberGenerator.Next(0, Console.WindowWidth));
                    }
                    while (snakeElements.Contains(food) || obstacles.Contains(food));
                    lastFoodTime = Environment.TickCount;

                    Console.SetCursorPosition(food.col, food.row);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("@");
                    sleepTime--;

                    Position obstacle;
                    do
                    {
                        //create new obsticle
                        obstacle = new Position(randomNumberGenerator.Next(0, Console.WindowHeight),
                            randomNumberGenerator.Next(0, Console.WindowWidth));
                    } 
                    while (snakeElements.Contains(obstacle) || obstacles.Contains(obstacle) || 
                        food.row == obstacle.row || food.col == obstacle.col);
                    obstacles.Add(obstacle);
                    Console.SetCursorPosition(obstacle.col, obstacle.row);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("!");

                }
                else
                {
                    // not feeding, removing last snake element
                    Position last = snakeElements.Dequeue();
                    Console.SetCursorPosition(last.col, last.row);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");
                }

                // check food expiration
                if (Environment.TickCount - lastFoodTime >= foodDissapearTime)
                {
                    negativePoints += 50;
                    // remove old food
                    Console.SetCursorPosition(food.col, food.row);
                    Console.Write(" ");

                    do
                    {
                        //create new food
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight),
                            randomNumberGenerator.Next(0, Console.WindowWidth));
                    }
                    while (snakeElements.Contains(food) || obstacles.Contains(food));
                    lastFoodTime = Environment.TickCount;

                    Console.SetCursorPosition(food.col, food.row);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("@");
                }

                Console.SetCursorPosition((Console.WindowWidth / 2)-5,0);
                Console.ForegroundColor = ConsoleColor.Red;
                userPoints = (snakeElements.Count - 6) * 100 - (int)negativePoints;
                userPoints = Math.Max(userPoints, 0);
                Console.WriteLine("points: {0}", userPoints);

                sleepTime -= 0.01;
                Thread.Sleep((int)sleepTime);
            }
        }
    }
}
