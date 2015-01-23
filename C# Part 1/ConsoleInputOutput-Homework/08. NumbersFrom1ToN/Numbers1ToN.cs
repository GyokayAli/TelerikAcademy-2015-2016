//Problem 8. Numbers from 1 to n
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class Numbers1ToN
{
        static void Main()
        {
            Console.Write("Please enter an integer number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
                Console.WriteLine(i);
        }
}

