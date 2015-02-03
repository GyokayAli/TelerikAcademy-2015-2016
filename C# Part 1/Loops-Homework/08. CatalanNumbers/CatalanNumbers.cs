//Problem 8. Catalan Numbers
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
        static void Main()
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger res = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));

            Console.WriteLine("The nth Catalan number is {0}",res);
        }
        private static BigInteger Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
}

