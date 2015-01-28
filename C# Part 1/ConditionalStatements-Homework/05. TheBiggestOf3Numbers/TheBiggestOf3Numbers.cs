//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers

using System;

class TheBiggestOf3Numbers
{
        static void Main()
        {
            Console.WriteLine("Enter three numbers: ");
            double[] numbers = new double[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("The biggest number is {0} ", 
                Math.Max(numbers[0], numbers[1]) > numbers[2] ? Math.Max(numbers[0], numbers[1]) : numbers[2]);
        }
}

