//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.
using System;


class OddOrEvenInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer to check if it is odd: ");
        int input = int.Parse(Console.ReadLine());

        if(input % 2 == 0)
            Console.WriteLine("False!");
        else
            Console.WriteLine("True");
    }
}

