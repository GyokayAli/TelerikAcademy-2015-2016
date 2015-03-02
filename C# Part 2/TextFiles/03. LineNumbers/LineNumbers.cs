//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        var reader = new StreamReader("../../Files/text.txt");
        var writer = new StreamWriter("../../Files/concatTexts.txt");

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    counter++;
                    line = line.Insert(0, "Line " + counter.ToString() + ": ");                   
                    writer.WriteLine(line);
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("\nNew file is written!");
        }
    }
}

