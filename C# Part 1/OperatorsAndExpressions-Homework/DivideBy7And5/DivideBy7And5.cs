//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
using System;


class DivideBy7And5
{
        static void Main()
        {
            Console.WriteLine("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());

            bool isDivisible = (input % 7 == 0) && (input % 5 == 0);

            Console.WriteLine(isDivisible);
        }
}

