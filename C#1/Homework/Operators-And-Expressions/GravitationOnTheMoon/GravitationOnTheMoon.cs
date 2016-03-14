// Problem 2. Gravitation on the Moon
// 
//     The gravitational field of the Moon is approximately 17% of that on the Earth.
//     Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
// 
// Examples:
// weight 	weight on the Moon
// 86 	14.62
// 74.6 	12.682
// 53.7 	9.129

namespace GravitationOnTheMoon
{
    using System;
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter person weight: ");
            double personWeight = double.Parse(Console.ReadLine());
            
            Console.WriteLine("weight on the moon: {0}", personWeight * 0.17);
        }
    }
}
