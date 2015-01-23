//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfNNumbers
{
        static void Main()
        {
            Console.Write("How many numbers you want to enter? ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("No numbers to enter!");
                return;
            }
            Console.WriteLine("Please enter {0} numbers!",n);

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe sum is {0:F1}\n",sum);
        }
}

