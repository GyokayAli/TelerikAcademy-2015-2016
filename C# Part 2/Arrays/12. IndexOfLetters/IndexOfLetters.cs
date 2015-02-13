//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Text;

class IndexOfLetters
{
        static void Main()
        {
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine().Trim().ToUpper();

            int[] indices = new int[word.Length];
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int index = 0; index < word.Length; index++)
            {
                indices[index] = Array.IndexOf(alphabet, word[index]);
            }

            StringBuilder result = new StringBuilder();
            for (int index = 0; index < indices.Length; index++)
            {
                result.Append(String.Format("letter {0} at index {1}\n", (char)(indices[index] + 'A'), indices[index]));
            }
            Console.WriteLine(result.ToString());
        }      
}

