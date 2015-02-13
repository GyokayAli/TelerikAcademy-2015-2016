//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;

//calculate all primes under 1,000,000 in 10ms !!!
class PrimeNumbers
{
        static void Main()
        {
            Console.Write("Please enter the max number: ");
            int max = int.Parse(Console.ReadLine());

            var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(max);
            var eliminated = new System.Collections.BitArray(max + 1);

            vals.Add(2);

            for (int i = 3; i <= max; i += 2)
            {
                if (!eliminated[i])
                {
                    if (i < maxSquareRoot)
                    {
                        for (int j = i * i; j <= max; j += 2 * i)
                            eliminated[j] = true;
                    }
                    vals.Add(i);
                }
            }
            Console.WriteLine(String.Join(", ", vals));
        }     
}

