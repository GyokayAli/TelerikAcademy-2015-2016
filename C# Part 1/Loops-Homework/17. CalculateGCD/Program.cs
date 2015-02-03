//Problem 17.* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD:\t" + GCD(first, second));
    }

    static int GCD(int a, int b)
    {
        int remainder;

        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }
}

