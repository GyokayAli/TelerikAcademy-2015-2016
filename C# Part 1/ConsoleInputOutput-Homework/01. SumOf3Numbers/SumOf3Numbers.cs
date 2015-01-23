//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.


using System;


class SumOf3Numbers
{
        static void Main()
        {
            Console.Write("Please enter a real number a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Please enter a real number b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Please enter a real number c: ");
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;

            Console.WriteLine("The sum of {0}, {1}, {2} is {3}.",a,b,c,sum);
        }
}

