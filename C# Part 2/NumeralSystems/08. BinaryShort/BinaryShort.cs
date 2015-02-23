//Problem 8. Binary short
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter a decimal number between {0} and {1}: ", short.MinValue, short.MaxValue);
        short decimalNumber = short.Parse(Console.ReadLine());

        Console.WriteLine("short DEC {0} -->> BIN {1}", decimalNumber, ConvertToBinary(decimalNumber));
    }

    static string ConvertToBinary(short decimalNumber)
    {
        string result = string.Empty;
        for (int i = 15; i >= 0; i--)
        {
            result = ((decimalNumber % 2) & 1) + result;
            decimalNumber >>= 1;

            if (i % 4 == 0) result = " " + result;
        }
        return result;
    }
}
