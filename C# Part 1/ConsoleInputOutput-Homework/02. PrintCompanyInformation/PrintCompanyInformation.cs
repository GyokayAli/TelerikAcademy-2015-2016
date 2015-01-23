//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
        static void Main()
        {
            Console.Write("Please enter Company name: ");
            string compName = Console.ReadLine();

            Console.Write("Please enter Company address: ");
            string compAddress = Console.ReadLine();

            Console.Write("Please enter Phone number: ");
            string phoneNum = Console.ReadLine();

            Console.Write("Please enter Fax number: ");
            string faxNum = Console.ReadLine();

            Console.Write("Please enter Web site: ");
            string website = Console.ReadLine(); 

            Console.Write("Please enter Manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Please enter Manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Please enter Manager age: ");
            string managerAge = Console.ReadLine();

            Console.Write("Please enter Manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(@"
{0}
Address: {1}
Tel: {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, tel. {8})", compName, compAddress, phoneNum, faxNum, website, managerFirstName,
                                      managerLastName, managerAge, managerPhone);         
        }
}

