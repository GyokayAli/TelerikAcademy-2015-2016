//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Linq;
using System.Text;

class DeletePrefix
{
    static void Main()
    {
        string inputPath = "../../Files/input.txt";
        string outputPath = "../../Files/output.txt";
        StringBuilder result = new StringBuilder();

        using (StreamReader reader = new StreamReader(inputPath))
        {
            string currentLine;
            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                Console.WriteLine("The input:\n{0}", currentLine);
                string[] separatedWords = currentLine
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                result.AppendLine(String.Join(" ", separatedWords));
            }           
        }

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.Write(result.ToString());
            Console.WriteLine("\nThe output:\n{0}", result.ToString());
        }
    }
}

