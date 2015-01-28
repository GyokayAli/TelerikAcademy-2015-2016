//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System.Linq;
using System;

class Sort3NumbersWithNestedIfs
{
        static void Main()
        {
            Console.WriteLine("Enter three numbers: ");

            double[] numbers = new double[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            if (numbers[0] == numbers.Max())
            {
                if (numbers[1] <= numbers[2])
                    Print(numbers[0], numbers[2], numbers[1]);
                else
                    Print(numbers[0], numbers[1], numbers[2]);
            }
            if (numbers[1] == numbers.Max())
            {
                if (numbers[0] <= numbers[2])
                    Print(numbers[1], numbers[2], numbers[0]);
                else
                    Print(numbers[1], numbers[0], numbers[2]);
            }
            if (numbers[2] == numbers.Max())
            {
                if (numbers[1] <= numbers[0])
                    Print(numbers[2], numbers[0], numbers[1]);
                else
                    Print(numbers[2], numbers[1], numbers[0]);
            }
        }

            private static void Print(double a, double b, double c)
        {
            Console.Clear();
            Console.WriteLine("{0}  {1}  {2}", a, b, c);
        }
}


