//Problem 10. Unicode characters
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
/*Example:
 *        input         output
 *         Hi!	   \u0048\u0069\u0021
 */

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Please enter a text or word: ");
        string text = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        foreach (var letter in text)
        {
            result.Append(String.Format("\\u{0:X4}", (int)letter));
        }
        Console.WriteLine(result.ToString());
    }
}

