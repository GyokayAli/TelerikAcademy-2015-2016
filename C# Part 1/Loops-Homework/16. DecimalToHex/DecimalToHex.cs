//Problem 16. Decimal to Hexadecimal Number
/*Using loops write a program that converts an integer number to its hexadecimal representation.
 *The input is entered as long. The output should be a variable of type string.
 *Do not use the built-in .NET functionality.
 */

using System;
using System.Text;

class DecimalToHex
{
        static void Main()
        {
            Console.WriteLine("Enter an integer number :");
            long num = long.Parse(Console.ReadLine());

            StringBuilder binary = new StringBuilder();
            while (num > 0)
            {
                int i = 0;
                char hexValue = '0';
                long remainder = num % 16;
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10: hexValue = 'A';
                            break;
                        case 11: hexValue = 'B';
                            break;
                        case 12: hexValue = 'C';
                            break;
                        case 13: hexValue = 'D';
                            break;
                        case 14: hexValue = 'E';
                            break;
                        case 15: hexValue = 'F';
                            break;
                        default: Console.WriteLine("Fail");
                            break;
                    }
                    binary.Insert(i, hexValue);
                }
                else
                {
                    binary.Insert(i, remainder);
                }
                num /= 16;
                i++;
            }
            Console.WriteLine("The decimal number {0} in Hex is {1}",num,binary);
        }
}

