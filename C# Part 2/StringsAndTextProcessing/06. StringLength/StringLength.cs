//Problem 6. String length
/*Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
 */

using System;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Please enter a text with 20 characters: ");
        string inputStr = Console.ReadLine();

        if (inputStr.Length > 20)
        {
            Console.WriteLine("\nYou entered more than expected!");
            return;
        }
        else if (inputStr.Length < 20)
        {
            Console.WriteLine("\n{0}", inputStr.PadRight(20, '*'));
        }
        else
        {
            Console.WriteLine("\n{0}", inputStr);
        }
    }
}

