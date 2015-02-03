//Problem 15. Hexadecimal to Decimal Number
/*Using loops write a program that converts a hexadecimal integer number to its decimal form.
 *The input is entered as string. The output should be a variable of type long.
 *Do not use the built-in .NET functionality.
 */ 

using System;
using System.Text;

class HexToDecimal
{
        static void Main()
        {
            Console.WriteLine("Enter a hexadecimal number :");
            string hex = Console.ReadLine();
            long num = 0;
            long pow = 1;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int sign;
                switch (hex[i])
                {
                    case 'A': sign = 10;
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
            Console.WriteLine("The Hex number {0} in decimal is {1}.",hex,num);

        }
}

