//Problem 10. Employee Data
//
//    A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//
//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)
//
//    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//    Use descriptive names. Print the data at the console.

namespace EmployeeData
{
    using System;
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Bill";
            string lastName = "Gates";
            int age = 42;
            bool isItMale = true;
            long personalID = 8306112507;
            string employeeNumber = "2756000078937894534535345633";

            string output = String.Format(@"
     First name: {0}
      Last name: {1}
            age: {2}
         Gender: {3}
    Personal ID: {4}
Employee number: {5}", firstName, lastName, age, isItMale?"Male":"Female", personalID, employeeNumber );

            Console.WriteLine(output);
        }
    }
}
