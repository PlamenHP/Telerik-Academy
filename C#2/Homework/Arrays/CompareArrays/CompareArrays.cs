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
            int n = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }

            int[] arrayTwo = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            bool equal = true;
            for (int i = 0; i < n; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    equal = false;
                }                    
            }

            Console.WriteLine("{0}", equal?"Equal":"Not equal");
        }
    }
}
