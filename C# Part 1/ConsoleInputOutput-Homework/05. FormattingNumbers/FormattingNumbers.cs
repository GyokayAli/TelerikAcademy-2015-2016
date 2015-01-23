//Problem 5. Formatting Numbers
/*
Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
 */

using System;

class FormattingNumbers
{
        static void Main()
        {
            Console.Write("Please enter integer 'a' (0 <= a <= 500): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter floating-point 'b': ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Please enter floating-point 'c': ");
            double c = double.Parse(Console.ReadLine());    

            Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a,2).PadLeft(10,'0'), b, c);         
        }
}

