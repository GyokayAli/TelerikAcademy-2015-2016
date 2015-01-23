//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfFiveNumbers
{
        static void Main()
        {
            Console.WriteLine("Please enter 5 numbers separated by space to find their Sum: ");
            string[] nums = Console.ReadLine().Split(' ');

            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += double.Parse(nums[i]);
            }

            Console.WriteLine("The sum is {0:F2}", sum);
        }
}

