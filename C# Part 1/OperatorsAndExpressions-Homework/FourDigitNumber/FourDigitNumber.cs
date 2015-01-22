//Problem 6. Four-Digit Number
/* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 * Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
 * Prints on the console the number in reversed order: dcba (in our example 1102).
 * Puts the last digit in the first position: dabc (in our example 1201).
 * Exchanges the second and the third digits: acbd (in our example 2101).
 * The number has always exactly 4 digits and cannot start with 0. */

using System;
using System.Linq;

class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Please enter a four-digit number: ");

            int[] digits = Console.ReadLine().ToCharArray().Select(x => Int32.Parse(x.ToString())).ToArray();


            Console.WriteLine("Sum of digits: {0}\nReversed digits: {1}\nLast digit-first: {2}\nSwap 2nd and 3rd: {3}",
                Sum(digits), Reverse(digits), LastDigitFirst(digits), SwapDigits(digits));          
        }

        

        //Calculates the sum of the digits
        static int Sum(int[] digits)
        {
            int sum = 0;
            foreach (var digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        //Puts the number in reversed order
        static string Reverse(int[] digits)
        {
            string revDigits = string.Join("", digits.Reverse());
            return revDigits;
        }

        //Puts the last digit in the first position
        static string LastDigitFirst(int[] digits)
        {
            string lastDigitFirst = "" + digits[digits.Length - 1];
            for (int i = 0; i < digits.Length - 1; i++)
            {
                lastDigitFirst += digits[i];
            }
            return lastDigitFirst;
        }

        //Exchanges the second and the third digits
        static string SwapDigits(int[] digits)
        {
            return digits[0].ToString() + digits[2] + digits[1] + digits[3];
        }           
}

