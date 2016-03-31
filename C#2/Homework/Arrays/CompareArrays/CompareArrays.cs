//  Problem 2. Compare arrays
//  
//      Write a program that reads two integer arrays from the console and compares them element by element.


namespace Namespace
{
    using System;
    class CompareArrays
    {
        static void Main()
        {
            Console.WriteLine("Problem 2. Compare arrays\n");
            Console.Write("Enter the lenght of the arrays: ");
            int arraylenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the first array:");

            int[] arrayOne = new int[arraylenght];
            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("element[{0}]=",i);
                arrayOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter the elements of the second array:");

            int[] arrayTwo = new int[arraylenght];
            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("element[{0}]=", i);
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            bool equal = true;
            for (int i = 0; i < arraylenght; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    equal = false;
                }                    
            }

            Console.WriteLine("The two arrays {0}, equal", equal?"are":"are not");
        }
    }
}
