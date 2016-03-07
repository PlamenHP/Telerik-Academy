using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Problem 1. Declare Variables
//
//    Declare five variables choosing for each of them the most appropriate of the types: 
//    byte, sbyte, short, ushort, int, uint, long, ulong 
//    to represent the following values: 
//    52130, -115, 4825932, 97, -10000.
//    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.


namespace DeclareVariables
{
    class DeclareVariables
    {

        static void Main()
        {
            List<BigInteger> digits = new List<BigInteger>();
            digits.Add(52130);
            digits.Add(-115);
            digits.Add(4825932);
            digits.Add(97);
            digits.Add(-10000);

            List<string> types = new List<string>();
            types.Add("System.SByte"); //sbyte
            types.Add("System.Byte"); //byte
            types.Add("System.Int16"); //short
            types.Add("System.UInt16"); //ushort
            types.Add("System.Int32"); //int
            types.Add("System.UInt32"); //uint
            types.Add("System.Int64"); //long
            types.Add("System.UInt64"); //ulong

            Console.WriteLine();
            Console.WriteLine(new string('-', 5) + "The numbers on the left will best fit the following Types:" + new string('-', 5));
            Console.WriteLine();

            foreach (BigInteger digit in digits)
            {
                foreach (string type in types)
                {
                    BigInteger minValue = BigInteger.Parse(Type.GetType(type).GetField("MinValue").GetValue(null).ToString());
                    BigInteger maxValue = BigInteger.Parse(Type.GetType(type).GetField("MaxValue").GetValue(null).ToString());

                    if ((minValue < digit) && (digit < maxValue))
                    {
                        Console.WriteLine("[{0,8}] will fit:   {1}   Range: [{2,12}] to [{3}]", digit, type ,minValue, maxValue);
                        break;
                    } 
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(new string('-',22)+ "Given Types Range" +new string('-',22));
            Console.WriteLine();
            Console.WriteLine("sbyte/SByte   {0,20} {1,20}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("byte/Byte     {0,20} {1,20}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("short/Int16   {0,20} {1,20}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort/UInt16 {0,20} {1,20}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int/Int32     {0,20} {1,20}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint/Uint32   {0,20} {1,20}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("long/Int64    {0,20} {1,20}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong/UInt64  {0,20} {1,20}", ulong.MinValue, ulong.MaxValue);
        }
    }
}
