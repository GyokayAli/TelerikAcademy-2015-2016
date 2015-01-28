//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;


class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Please enter real number a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please enter real number b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please enter real number c: ");
        double c = double.Parse(Console.ReadLine());

        double product = a * b * c;

        if (product > 0)
            Console.WriteLine("The sign is + ");
        else if (product == 0)
            Console.WriteLine("The result is 0");
        else
            Console.WriteLine("The sign is - ");
    }
}
