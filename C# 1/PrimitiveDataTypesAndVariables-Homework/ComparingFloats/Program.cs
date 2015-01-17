//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
/* Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
 * floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

using System;


namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter floating-point number a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter floating-point number b:");
            double b = Convert.ToDouble(Console.ReadLine());

            bool preciseEqual = Math.Abs(a - b) < 0.000001;

            Console.WriteLine("a == b is "+ preciseEqual);
        }
    }
}
