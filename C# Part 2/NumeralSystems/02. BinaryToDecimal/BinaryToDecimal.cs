//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.

using System;

    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter a binary number :");
            string binStr = Console.ReadLine();

            long num = 0;
            int pow = 1;
            for (int i = binStr.Length - 1; i >= 0; i--)
            {
                int sign = binStr[i] - 48;
                if (sign == 1)
                {
                    num += sign * pow;
                }
                pow *= 2;
            }
            Console.WriteLine("The binary number {0} in decimal is {1}", binStr, num);
        }
    }

