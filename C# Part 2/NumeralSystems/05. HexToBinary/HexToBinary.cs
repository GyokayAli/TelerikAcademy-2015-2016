//Problem 5. Hexadecimal to binary
//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinary
{
    static void Main()
    {
        Console.Write("Please enter a HEX number: ");
        string hex = Console.ReadLine().ToUpper();

        Console.Write("\nHEX {0} -->> BIN {1}\n", hex, Convert.ToString(Convert.ToInt32(hex, 16), 2));
    }
}
