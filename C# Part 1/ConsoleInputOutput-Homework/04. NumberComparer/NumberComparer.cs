//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
        static void Main()
        {
            Console.Write("Please enter real number a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Please enter real number b: ");
            double b = double.Parse(Console.ReadLine());

            bool isGreater = a > b;

            Console.Write("The greater number is {0} ", isGreater ? a : b);
        }
}

