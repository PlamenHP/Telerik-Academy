//  Problem 19.* Permutations of set
//  
//      Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//  
//  Example:
//  N        result
//  3 	    {1, 2, 3}
//          {1, 3, 2}
//          {2, 1, 3}
//          {2, 3, 1}
//          {3, 1, 2}
//          {3, 2, 1}

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    class PermutationsOfSet
    {
        static void Main()
        {
            Console.WriteLine("Problem 19.* Permutations of set \n");
            Console.Write("Enter a number N= ");
            int n = int.Parse(Console.ReadLine());

            GeneratePermutations(n);
        }

        private static void GeneratePermutations(int range)
        {
            int selectionsLeft = range;
            Stack<int> selected = new Stack<int>();
            Queue<int> set = new Queue<int>();

            // initialise the set of numbers to choose from
            for (int i = 1; i <= range; i++)
            {
                set.Enqueue(i);
            }

            for (int i = 1; i <= range; i++)
            {
                selected.Push(set.Dequeue());
                GenerateNode(set, selected, selectionsLeft-1);
                set.Enqueue(selected.Pop());
            }

        }

        private static void GenerateNode(Queue<int> set, Stack<int> selected, int selectionsLeft)
        {
            if (selectionsLeft>0)
            {
                for (int i = 1; i <= selectionsLeft; i++)
                {
                    selected.Push(set.Dequeue());
                    GenerateNode(set, selected, selectionsLeft-1);
                    set.Enqueue(selected.Pop());
                }
            }
            else
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", selected));
            }
        }
    }
}
