//Problem 11. Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0
//The result of the expression should be either 1 or 0.

using System;


class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer : ");
            int num = int.Parse(Console.ReadLine());

            int pos = 3;
            int mask = 1 << pos;
            int numberAndmask = num & mask;
            int bit = numberAndmask >> pos;

            Console.WriteLine("The value of the bit #3 is: " + bit);
        }
}
