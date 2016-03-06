using System;

namespace Telerik_Academy_Exam_CSharp_Part_1
{
    class Exam_3_6_8
    {
        public static void Main()
        {
            long a = int.Parse(Console.ReadLine());
            long b = int.Parse(Console.ReadLine());
            long c = int.Parse(Console.ReadLine());

            long result = 0;
            if (b == 3)
            {
                result = a + c;
            }
            else if (b == 6)
            {
                result = a * c;
            }
            else if (b == 9)
            {
                result = a % c;
            }

            long result2 = 0;
            if ((result % 3) == 0)
            {
                result2 = result / 3;
            }
            else
            {
                result2 = result % 3;
            }

            Console.WriteLine(result2);
            Console.WriteLine(result);
        }
    }
}
