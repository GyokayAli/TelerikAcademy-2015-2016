//Problem 11. Bank Account Data
/*
  A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
  Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/

using System;


namespace BankAccountData
{
    class Program
    {
        static void Main()
        {
            string firstName = "George";
            string midName = "The Handsome";
            string lastName = "Michael";
            object fullName = firstName + " " + midName + " " + lastName;
            decimal balance = 199000.5500m;
            string bank = "HSBC";
            string ibanNo = "UK837812743812398991GB";
            long cardNum1 = 12345678901;
            long cardNum2 = 12345678902;
            long cardNum3 = 12345678903;

            Console.WriteLine("Name: {0} \nBalance: {1} \nBank: {2} \nIBAN: {3} \nCard 1: {4} \nCard 2: {5} \nCard 3: {6}", fullName, balance, bank, ibanNo, cardNum1, cardNum2, cardNum3);         
        }
    }
}
