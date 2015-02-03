//Problem 13. Binary to Decimal Number
/*Using loops write a program that converts a binary integer number to its decimal form.
 *The input is entered as string. The output should be a variable of type long.
 *Do not use the built-in .NET functionality.
 */

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
