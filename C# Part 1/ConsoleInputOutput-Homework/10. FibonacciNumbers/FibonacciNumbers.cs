//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,)
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciNumbers
{
        static void Main()
        {
            Console.Write("Please enter integer n: ");
            int n = int.Parse(Console.ReadLine());
            long a = 0;
            long b = 1;

            if (n < 1)
            {
                Console.WriteLine("No number to show.");
                return;
            }

            // Prints out the first number 0
            Console.Write("\n"+ a + " ");
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n-1; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
                Console.Write(a + " ");    
            }
            Console.WriteLine("\n");
        }
}

