using System;

namespace Problem_1_Printing
{
    class Problem_1_Printing
    {
        public static void Main()
        {
            int nStudentCount = 0;
            int sSheetsPerStudent = 0;
            decimal pRealmPrice = 0;
            const int SHEETS_IN_REALM = 500;

            nStudentCount = int.Parse(Console.ReadLine());
            sSheetsPerStudent = int.Parse(Console.ReadLine());
            pRealmPrice = decimal.Parse(Console.ReadLine());

            int totalSheetsOfPaper = nStudentCount * sSheetsPerStudent;
            decimal realmsCount = (decimal)totalSheetsOfPaper / SHEETS_IN_REALM;
            decimal totalCost = realmsCount * pRealmPrice;

            Console.WriteLine("{0:F2}", totalCost);
        }
    }
}
