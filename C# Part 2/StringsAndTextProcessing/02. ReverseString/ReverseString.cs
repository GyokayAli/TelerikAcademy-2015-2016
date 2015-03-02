//Problem 2. Reverse string
//Write a program that reads a string, reverses it and prints the result at the console.
/* Example
 *         input   output
 *         sample  elpmas
 */

using System;
using System.Linq;
class ReverseString
{
    static void Main()
    {
        Console.Write("Please enter a word: ");
        string inputWord = Console.ReadLine();
        char[] cArray = inputWord.ToCharArray();

        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        Console.WriteLine("{0} reversed --> {1}",inputWord,reverse);
    }
}

