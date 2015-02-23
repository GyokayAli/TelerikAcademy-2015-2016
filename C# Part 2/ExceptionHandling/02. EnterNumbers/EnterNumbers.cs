//Problem 2. Enter numbers
/*Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class EnterNumbers
{
    static int MIN = 1;
    static int MAX = 100;

    static void Main()
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                MIN = ReadNumber(MIN, MAX);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye.");
        }
    }
    private static int ReadNumber(int start, int end)
    {
        Console.Write("Enter number in range [{0}...{1}]: ", MIN + 1, MAX - 1);
        int number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }
}

