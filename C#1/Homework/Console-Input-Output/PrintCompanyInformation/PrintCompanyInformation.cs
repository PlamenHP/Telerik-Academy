// Problem 2. Print Company Information
// 
//     A company has name, address, phone number, fax number, web site and manager. 
//     The manager has first name, last name, age and a phone number.
//     Write a program that reads the information about a company and its manager and prints it back on the console.
// 
// Example input:
// program 	user
// Company name: 	    Telerik Academy
// Company address: 	31 Al. Malinov, Sofia
// Phone number: 	    +359 888 55 55 555
// Fax number: 	
// Web site:        	http://telerikacademy.com/
// Manager first name: 	Nikolay
// Manager last name: 	Kostov
// Manager age: 	    25
// Manager phone: 	   +359 2 981 981

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    class PrintCompanyInformation
    {
        static void Main()
        {
            List<string> companyInfoTemplate = new List<string>{ "Company name", "Company address", "Phone number", 
                                                                 "Fax number", "Web site","Manager first name",
                                                                 "Manager last name","Manager age","Manager phone" };
            List<string> companyInfo = new List<string>();

            for (int i = 0; i < companyInfoTemplate.Count; i++)
            {
                Console.Write("Enter {0}: ", companyInfoTemplate[i]);
                companyInfo.Add(Console.ReadLine());
            }

            for (int i = 0; i < companyInfoTemplate.Count; i++)
            {
                Console.WriteLine("{0,30}: {1,-25}", companyInfoTemplate[i], companyInfo[i]);
            }
        }
    }
}
