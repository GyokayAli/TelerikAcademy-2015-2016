//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter a hexadecimal number :");
            string hex = Console.ReadLine();
            long num = 0;
            long pow = 1;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int sign;
                switch (hex[i])
                {
                    case 'A' : sign = 10;
                        break;
                    case 'B': sign = 11;
                        break;
                    case 'C': sign = 12;
                        break;
                    case 'D': sign = 13;
                        break;
                    case 'E': sign = 14;
                        break;
                    case 'F': sign = 15;
                        break;
                    default: sign = hex[i] - 48;
                        break;
                }
                num += sign * pow;
                pow *= 16;
            }
            Console.WriteLine("\nThe Hex number {0} in decimal is {1}.\n", hex, num);
        }
    }

