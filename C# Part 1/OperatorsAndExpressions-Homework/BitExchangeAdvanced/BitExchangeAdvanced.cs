//Problem 16.** Bit Exchange (Advanced)
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;


class BitExchangeAdvanced
{
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position P: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter position Q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter step K: ");
            int k = int.Parse(Console.ReadLine());


            for (int firstIndices = p, secondIndices = q, length = k;
            (firstIndices < 32 && secondIndices < 32) && length > 0;
            firstIndices++, secondIndices++, length--)
            {
                if (((n >> firstIndices) & 1) != ((n >> secondIndices) & 1))
                {
                    n = changeBits(n, firstIndices, secondIndices);
                }
            }
            Console.WriteLine("Result: {0}", n);
            Console.ReadKey();
        }

        private static int changeBits(int number, int firstposition, int secondPosition)
        {
            number ^= (1 << firstposition);
            return number ^ (1 << secondPosition);
        }       
}


