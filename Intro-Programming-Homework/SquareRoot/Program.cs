//Problem 8
//Create a console application that calculates and prints the square root of the number 12345

using System;


namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            Console.WriteLine("Square root of " + num + " is " + Math.Sqrt(num));     
        }
    }
}
