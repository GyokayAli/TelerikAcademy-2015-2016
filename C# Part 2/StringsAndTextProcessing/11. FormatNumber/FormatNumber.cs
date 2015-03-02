//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15} in Decimal", number);
        Console.WriteLine("{0,15:X} in Hexadecimal", number);
        Console.WriteLine("{0,15:P} in Percentage", number / 100.0);
        Console.WriteLine("{0,15:E} in Scientific Notation", number);
    }
}

