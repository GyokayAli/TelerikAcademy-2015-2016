//Problem 10. Employee Data
/*
 A marketing company wants to keep record of its employees. Each record would have the following characteristics:
 First name
 Last name
 Age (0...100)
 Gender (m or f)
 Personal ID number (e.g. 8306112507)
 Unique employee number (27560000…27569999)
 Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/
using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Michael";
            string lastName = "Jordan";
            int age = 23;
            char gender = 'm';
            long id = 8306112507;
            int empNo = 27569998;

            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID No: {4}\nUnique Emp No: {5}",firstName,lastName,age,gender,id,empNo);           
        }
    }
}
