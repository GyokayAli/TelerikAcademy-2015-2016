//Problem 3. English digit
//Write a method that returns the last digit of given integer as an English word.
/*Example:
 *   1456  -->> six
 *   321   -->> one
 *   1990  -->> zero
 */

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        int lastdigit = (num % 10);

        Console.WriteLine("Last digit as word is: " + GetLastDigitAsWord(lastdigit));
    }

    static string GetLastDigitAsWord(int digit)
    {
        string word = "";
        switch (digit)
        {
            case 0: word = "zero";
                break;
            case 1: word = "one";
                break;
            case 2: word = "two";
                break;
            case 3: word = "three";
                break;
            case 4: word = "four";
                break;
            case 5: word = "five";
                break;
            case 6: word = "six";
                break;
            case 7: word = "seven";
                break;
            case 8: word = "eight";
                break;
            case 9: word = "nine";
                break;
        }
        return word;
    }
}

