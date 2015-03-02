//Problem 8. Extract sentences
//Write a program that extracts from a given text all sentences containing given word.
/*Example:

The word is: "in"

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
*/
using System;

class ExtractSentence
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
    So we are drinking all the day. We will move out of it in 5 days.";
        string[] sentences = text.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            if(sentences[i].Contains(" in ") || sentences[i].Contains("In ") || sentences[i].Contains(" in"))
            {
                Console.Write(sentences[i].Trim() + ". ");
            }
        }
        Console.WriteLine("\n");
    }
}

