//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;


class ExtractBitFromInteger
{
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer n: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Please enter the value of given bit at index p: ");
            int pos = int.Parse(Console.ReadLine());

            int bit = (num >> pos) & 1;
            Console.WriteLine("The bit at index {0} is : {1}",pos,bit);
        }
}

