//  Problem 3. Compare char arrays
//  
//      Write a program that compares two char arrays lexicographically (letter by letter).


namespace Namespace
{
    using System;
    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Problem 3. Compare char arrays\n");
            Console.Write("Enter a word for the first char array: ");
            string arrayOne = Console.ReadLine();
            Console.Write("Enter a word for the second char array: ");
            string arrayTwo = Console.ReadLine();

            int compareResult = My_LexicographicCharArrayComparer.Compare(arrayOne,arrayTwo);
            string result = string.Empty;

            if (compareResult == 0)
            {
                result = "The char arrays are equal";
            } 
            else
            {
                result = compareResult > 0? "The first char array is first lexicographicly" : "The second char array is first lexicographicly" ;
            }

            Print(result);
        }

        private static void Print(string result)
        {
            Console.WriteLine(result);
        }
    }
}
