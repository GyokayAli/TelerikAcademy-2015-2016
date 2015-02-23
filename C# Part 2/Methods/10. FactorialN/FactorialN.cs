//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

class FactorialN
    {
        static void Main()
        {
            for (int j = 1; j <= 100; j++)
            {
                Console.WriteLine("{0}! -> {1}",j, Factorial(j));
            }
        }

        // recursive method
        static BigInteger Factorial(BigInteger i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }
