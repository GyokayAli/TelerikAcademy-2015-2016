//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
        }
    }

