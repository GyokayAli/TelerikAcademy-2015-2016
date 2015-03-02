//Problem 3. Correct brackets
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBracket
{
    static void Main()
    {
        Console.Write("Please input an expression: ");
        string expression = Console.ReadLine();

        int bracketCount = 0;
        bool isCorrectOrder = true;
        foreach (var letter in expression)
        {
            if (letter == '(')
                ++bracketCount;
            else if (letter == ')')
                --bracketCount;

            if (bracketCount < 0)
                isCorrectOrder = false;
        }

        Console.WriteLine("Brackets are correct? --> {0}", isCorrectOrder ? "CORRECT" : "INCORRECT");
    }
}

