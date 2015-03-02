//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        var firstReader = new StreamReader("../../Files/text1.txt");
        var secondReader = new StreamReader("../../Files/text2.txt");
        var fileWriter = new StreamWriter("../../Files/concatTexts.txt");

        using (fileWriter)
        {
            using (firstReader)
            {
                Console.WriteLine("Text 1:");
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    fileWriter.WriteLine(line);
                    line = firstReader.ReadLine();
                }
            }

            using (secondReader)
            {
                Console.WriteLine("\nText 2:");
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    fileWriter.WriteLine(line);
                    line = secondReader.ReadLine();
                }
            }
            Console.WriteLine("\nNew file is written!");
        }
    }
}

