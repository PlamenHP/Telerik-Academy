//  Problem 12.** Falling Rocks
//  
//      Implement the "Falling Rocks" game in the text console.
//
//          A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//
//          A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//
//          Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//
//      Ensure a constant game speed by Thread.Sleep(150).
//
//      Implement collision detection and scoring system.

namespace FallingRocks
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    class FallingRocks
    {
        // Elements structure
        public struct Element
        {
            public int col;
            public char avatar;
            public ConsoleColor color;
            public Element(int col, char avatar = ' ', ConsoleColor color = ConsoleColor.Gray)
            {
                this.col = col;
                this.avatar = avatar;
                this.color = color;
            }
        }

        static char[] rockAvatar = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        static ConsoleColor[] rockColor = new ConsoleColor[] { ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.Cyan };
        static Random random = new Random();
        static int scores = 0;
        static double speed = 1;
        static int menuHeight = 4;
        static int dwarfRowIndex = Console.WindowHeight - 1;

        // row of rocks generator
        public static List<Element> GenerateRocksRow()
        {
            List<Element> rocksRow = new List<Element>();
            // number of rocks on the row
            int rocksCount = random.Next(1, 4);
            Element rockElement;
            //generate rocks
            int lastElementPosition = 0;
            for (int i = 0; i < rocksCount; i++)
            {
                ConsoleColor color = rockColor[random.Next(0, rockColor.Length - 1)];
                char avatar = rockAvatar[random.Next(0, rockAvatar.Length-1)];
                int rockWidth = random.Next(1, 4);
                int distance = random.Next(0, 50);
                rockElement = new Element(lastElementPosition + distance);
                if (rockElement.col + rockWidth > Console.WindowWidth) break;

                for (int j = 0; j < rockWidth; j++)
                {
                    rocksRow.Add(new Element(rockElement.col + j, avatar, color));
                    lastElementPosition = rockElement.col + j;
                }
            }
            return rocksRow;
        }

        // moving rocks down
        public static void MoveObstaclesDown(Queue<List<Element>> obstacles)
        {
            List<Element> rockRow = GenerateRocksRow();
            obstacles.Enqueue(rockRow);

            if (obstacles.Count > Console.WindowHeight - menuHeight)
            {
                obstacles.Dequeue();
            }
        }

        public static void DrawObstacles(Queue<List<Element>> obstacles)
        {
            int rowIndex = obstacles.Count - 1 + menuHeight;
            foreach (var row in obstacles)
            {
                foreach (var element in row)
                {
                    Console.SetCursorPosition(element.col, rowIndex);
                    Console.ForegroundColor = element.color;
                    Console.Write(element.avatar);
                }
                rowIndex--;
            }
        }

        public static void MoveDwarf(List<Element> dwarf, int direction)
        {
            if ((dwarf[0].col + direction >= 0)&&(dwarf[2].col+direction<Console.WindowWidth))
            {
                dwarf[0] = new Element(dwarf[0].col + direction, dwarf[0].avatar, dwarf[0].color);
                dwarf[1] = new Element(dwarf[1].col + direction, dwarf[1].avatar, dwarf[1].color);
                dwarf[2] = new Element(dwarf[2].col + direction, dwarf[2].avatar, dwarf[2].color);
            }
        }

        public static bool CollisionDetection(List<Element> dwarf, Queue<List<Element>> obstacles)
        {
            bool collision = false;
            if (obstacles.Count == Console.WindowHeight - menuHeight)
            {
                foreach (var element in obstacles.Peek())
                {
                    if (element.col == dwarf[0].col ||
                        element.col == dwarf[1].col ||
                        element.col == dwarf[2].col)
                    {
                        collision = true;
                    }
                    // give a score for each rock 
                    scores += 100;
                }
            }
            return collision;
        }

        // draw dwarf
        public static void DrawDwarf(List<Element> dwarf)
        {
            Console.SetCursorPosition(dwarf[0].col, dwarfRowIndex);
            Console.ForegroundColor = dwarf[0].color;
            Console.Write("(O)");
        }

        // draw menu
        public static void DrawInfoBar()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, 3);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write('=');
            }
            ShowScores();
        }

        public static void ShowScores()
        {
            Console.SetCursorPosition(Console.WindowWidth - 20, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SCORES:{0}", scores);
            Console.SetCursorPosition(Console.WindowWidth - 30, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SPEED:{0}", (int)speed);

        }

        public static void GameOver()
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - 4, 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            return;
        }

        static void Main()
        {
            // initialisations
            int left = -1;
            int right = 1;
            int stop = 0;
            int direction = 0;
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            Console.Title = "Falling Rocks";
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            // create dwarf
            List<Element> dwarf = new List<Element>()
            {
                new Element((Console.WindowWidth/2)-1, '(', ConsoleColor.Green),
                new Element((Console.WindowWidth/2),   'O', ConsoleColor.Green),
                new Element((Console.WindowWidth/2)+1, ')', ConsoleColor.Green)
            };

            // create the que of rockRows
            Queue<List<Element>> obstacles = new Queue<List<Element>>();

            while (true)
            {
                // read user input
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(false);
                    if (userInput.Key == ConsoleKey.LeftArrow) direction = left;
                    if (userInput.Key == ConsoleKey.RightArrow) direction = right;
                    if (userInput.Key == ConsoleKey.DownArrow) direction = stop;
                }

                //move rocks rows down
                MoveObstaclesDown(obstacles);
                // move dwarf left or right
                MoveDwarf(dwarf, direction);

                //collision detection
                if (CollisionDetection(dwarf, obstacles))
                {
                    GameOver();
                    return;
                }

                Console.Clear();
                // draw dwarf
                DrawDwarf(dwarf);
                // draw the rows of rocks
                DrawObstacles(obstacles);
                // show new scores
                DrawInfoBar();

                speed += 0.1;
                Thread.Sleep(150 - (int)speed);
            }
        }
    }
}
