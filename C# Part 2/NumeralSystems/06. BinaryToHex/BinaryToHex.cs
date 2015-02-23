//Problem 6. binary to hexadecimal
//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHex
{
    static void Main()
    {
        Console.Write("Please enter a Binary number: ");
        string binary = Console.ReadLine();

        Console.WriteLine("\nBIN {0} -->> HEX {1}\n", binary, Convert.ToInt32(binary, 2).ToString("X"));
    }
}

