//Problem 1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values if the 
//first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter the first double number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the first double number: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("The result: {0} {1}", b, a);
        else
            Console.WriteLine("The result: {0} {1}", a, b);
    }
}