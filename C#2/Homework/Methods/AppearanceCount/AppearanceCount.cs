//  Problem 4. Appearance count
//  
//      Write a method that counts how many times given number appears in given array.
//      Write a test program to check if the method is workings correctly.
//  

namespace Namespace
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class AppearanceCount
    {
        static void Main()
        {
            Random rnd = new Random();
        }

        static int CountAppearance(int[] array)
        {
            int result = 0;
            Dictionary<int,int> data = new Dictionary<int,int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (data.ContainsKey(i))
                {
                    data[i]++;
                }
                else
                {
                    data.Add(i, 1);
                }
            }
            result = data.Values.Max();
            return result;
        }
    }
}
