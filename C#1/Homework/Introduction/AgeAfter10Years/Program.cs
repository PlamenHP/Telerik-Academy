using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Enter your birthdate in the format: dd/mm/yy: ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Today;
            int age = now.Year - birthdate.Year;
            if (now < birthdate.AddYears(age)) age--;

            Console.WriteLine(new string('-',50));
            Console.WriteLine("Your current age is: {0}",age);
            Console.WriteLine("Your age after 10 Years will be: {0}", age + 10);
        }
    }
}
