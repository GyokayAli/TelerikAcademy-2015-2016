//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class DivideFactorials
{
        static void Main()
        {
            Console.Write("Please enter N > 1: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter K < N < 100: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger res = 1;
            if (1 < k && k < n && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    res *= i;
                }
            }
            else
            {
                Console.WriteLine("Please try again!");
            }

            Console.WriteLine("N! / K! = " + res + "");
        }
}

