//Problem 11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumsInRange
{
        static void Main()
        {
            Console.Write("Enter how many numbers will be printed: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter min value: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter max value: ");
            int max = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", r.Next(min, max+1));
            }
        }
}

