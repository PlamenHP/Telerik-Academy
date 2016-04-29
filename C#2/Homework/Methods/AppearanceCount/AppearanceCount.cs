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
            int length = rnd.Next(10, 20);
            List<int> array = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                array.Add(rnd.Next(0, 10));
            }
            array.ForEach(x => Console.Write("{0} ",x));
            Console.WriteLine();

            int result = CountAppearance(array);
            Console.WriteLine("{0}",result);
        }

        static int CountAppearance(List<int> array)
        {
            int result = 0;
            Dictionary<int,int> data = new Dictionary<int,int>();

            for (int i = 0; i < array.Count; i++)
            {
                if (data.ContainsKey(array[i]))
                {
                    data[array[i]]++;
                }
                else
                {
                    data.Add(array[i], 1);
                }
            }

            result = data.Values.Max();
            return result;
        }
    }
}
