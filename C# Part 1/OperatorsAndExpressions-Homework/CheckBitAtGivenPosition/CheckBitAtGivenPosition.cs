//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;


class CheckBitAtGivenPosition
{
        static void Main()
        {
            Console.Write("Please enter an integer n: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Please enter the value of given bit at index p: ");
            int pos = int.Parse(Console.ReadLine());

            bool checkBit = ((num >> pos) & 1) == 1;

            Console.WriteLine("The bit at position {0} is 1: {1}",pos,checkBit);
        }
}

