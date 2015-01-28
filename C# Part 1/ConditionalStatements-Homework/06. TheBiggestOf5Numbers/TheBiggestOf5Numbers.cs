//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements

using System.Linq;
using System;

class TheBiggestOf5Numbers
{
        static void Main()
        {
            Console.WriteLine("Enter five numbers: ");
            double[] numbers = new double[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double max = 0;
            if (numbers[0] == numbers.Max())
            {
                max = numbers[0];
            }
            if (numbers[1] == numbers.Max())
            {
                max = numbers[1];
            }
            if (numbers[2] == numbers.Max())
            {
                max = numbers[2];
            }
            if (numbers[3] == numbers.Max())
            {
                max = numbers[3];
            }
            if (numbers[4] == numbers.Max())
            {
                max = numbers[4];
            }
            Console.WriteLine("The biggest of five numbers is {0} ", max);
        }
}

