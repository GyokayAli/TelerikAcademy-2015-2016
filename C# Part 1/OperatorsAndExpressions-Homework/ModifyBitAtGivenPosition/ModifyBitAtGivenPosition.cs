//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitAtGivenPosition
{
        static void Main()
        {
            Console.Write("Please enter an integer n: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Please enter a bit value (0 or 1): ");
            int v = int.Parse(Console.ReadLine());

            Console.Write("Please enter the value of given bit at index p: ");
            int pos = int.Parse(Console.ReadLine());

            if (((num >> pos) & 1) != v)
                num ^= (1 << pos);

            Console.WriteLine("Modified number: {0}", num);
        }
}

