//  Problem 21. Letters count
//  
//      Write a program that reads a string from the console and prints all different
//     letters in the string along with information how many times each letter is found.


namespace LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] letters = new int[65536];

            foreach (char letter in input)
            {
                letters[letter]++;
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i]!=0 && i>='A'&& i<='z')
                {
                    Console.WriteLine("letter {0} {1} times", (char)i, letters[i]);
                }               
            }
        }
    }
}
