//Problem 15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
        static void Main(string[] args)
        {
            Console.Write("Enter an unsigned integer: ");
            int n = int.Parse(Console.ReadLine());

            int pos1 = 3;
            int pos2 = 24;

            int mask1 = 7 << pos1;
            int mask2 = 7 << pos2;

            int numAndMask1 = n & mask1;
            int numAndMask2 = n & mask2;

            int change = (n & ~mask1) & ~mask2;

            int mask3 = (numAndMask1 >> pos1) << pos2;
            int mask4 = (numAndMask2 >> pos2) << pos1;

            int result = (change | mask3) | mask4;


            Console.WriteLine("Result: {0}",result);
        }
}

