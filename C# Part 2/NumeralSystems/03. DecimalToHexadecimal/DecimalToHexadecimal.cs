//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Text;

    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter a decimal number: ");
            int num = int.Parse(Console.ReadLine());
            int dec = num;
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
            Console.WriteLine("The decimal number {0} in Hex is {1}", dec, binary);
        }
    }

