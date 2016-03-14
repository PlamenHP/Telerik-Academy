//Problem 8. Isosceles Triangle
//
//    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//
//   ©
//
//  © ©
//
// ©   ©
//
//© © © ©


namespace IsoscelesTriangle
{
    using System;
    using System.Text;
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char copyright = '\u00A9';
            string output = String.Format(@"
   {0}
   
  {0} {0}

 {0}   {0}

{0} {0} {0} {0}", copyright);

            Console.WriteLine(output);

        }
    }
}
