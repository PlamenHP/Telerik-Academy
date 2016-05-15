//  Problem 1. Strings in C#.
//  
//      Describe the strings in C#.
//      What is typical for the string data type?
//      Describe the most important methods of the String class.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StringsInCSharp
    {
        static void Main()
        {
            string text = "Describe the strings in C#.    ";
            Console.WriteLine(text);
            char c = text[0];// 'D'
            Console.WriteLine(c);
            string reverse = new string(text.Reverse().ToArray());//.#C ni sgnirts eht ebircseD
            Console.WriteLine(reverse);
            string java = text.Replace("C#", "Java");//Describe the strings in Java.
            Console.WriteLine(java);
            string noEndSpace = text.TrimEnd();
            Console.WriteLine(noEndSpace);
            int i = text.IndexOf("D");
            Console.WriteLine(i);
            string[] words = text.Split(' ');
            Console.WriteLine();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }           
        }
    }
}
