using System;

namespace Diamond_Trolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int height = (6 + ((n - 3) / 2) * 3);
            int width = (2*n)+1; 

            //diamond top
            Console.WriteLine(new string('.',(width - n)/2) + 
                              new string('*',n) + 
                              new string('.',(width - n)/2));

            //diamond upper part
            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.WriteLine(new string('.', ((n - 1) / 2) - i) + 
                                  "*" +
                                  new string('.', ((n - 1) / 2) + i) +
                                  "*" +
                                  new string('.', ((n - 1) / 2) + i) +
                                  "*" +
                                  new string('.', ((n - 1) / 2) - i));
            } 


            //diamond middle
            Console.WriteLine(new string('*', width));

            //diamond lower part
            for (int i = 0; i < n-1 ; i++)
            {
                Console.WriteLine(new string('.', (1 + i)) +
                                  "*" +
                                  new string('.', (n - 2) - i) +
                                  "*" +
                                  new string('.', (n - 2) - i) +
                                  "*" +
                                  new string('.', (1 + i)));
            }

            //diamond bottom
            Console.WriteLine(new string('.', n) + "*" + new string('.', n));
        }
    }
}
