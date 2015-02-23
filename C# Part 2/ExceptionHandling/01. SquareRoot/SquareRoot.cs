//Problem 1. Square root
/*Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */

using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number to calculate its Square root: ");

        try
        {
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine("The square root is: {0}", SqrRoot(input));
        }
        catch (FormatException fex)
        {
            Console.WriteLine("Invalid input!");
        }
        catch (ArgumentOutOfRangeException aex)
        {
            Console.WriteLine("Invalid input!");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }

    }
    public static double SqrRoot(double value)
    {
        if (value < 0)
            throw new System.ArgumentOutOfRangeException(
               "Sqrt for negative numbers is undefined!");
        return Math.Sqrt(value);
    }
}

