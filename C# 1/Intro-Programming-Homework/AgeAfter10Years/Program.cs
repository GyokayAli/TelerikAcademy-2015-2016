//Problem 15
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;


namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Please enter your date of birth! eg: 01/08/2008");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            //365 for the days in a year. +0.25 for leap years. +0.005 for other corrections 
            int age = (int)((DateTime.Now - dateOfBirth).TotalDays / 365.242199);

            Console.WriteLine("\nNow you are " + age + " years old.");
            Console.WriteLine("After 10 years you will be " + (age+10) + " years old.");
        }
    }
}
