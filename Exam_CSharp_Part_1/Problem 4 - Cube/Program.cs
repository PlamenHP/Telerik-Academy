using System;

namespace Cube
{
    public class Cube
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n - 1) + new string(':', n));

            for (int i = 1; i <= (n - 2); i++)
            {
                Console.WriteLine(new string(' ', (n - i - 1)) + new string(':', 1) + new string('/', (n - 2)) + new string(':', 1) + new string('X', (i - 1)) + new string(':', 1));
            }

            Console.WriteLine(new string(':', n) + new string('X', n - 2) + new string(':', 1));

            for (int i = 1; i <= (n - 2); i++)
            {
                Console.WriteLine(new string(':',1) + new string(' ', (n-2)) + new string(':', 1) + new string('X', n-i -2) + new string(':', 1));
            }

            Console.WriteLine(new string(':', n) + new string(' ', n - 1));
        }
    }
}
