//Problem 7. Replace sub-string
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubStrings
{
    static void Main()
    {
        var readFile = new StreamReader("../../Files/substrings.txt");
        var writeFile = new StreamWriter("../../Files/replaced.txt");

        using (writeFile)
        {
            using (readFile)
            {
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    Console.WriteLine("Input text:\n {0}", line);

                    line = line.ToLower();
                    line = line.Replace("start", "finish");

                    Console.WriteLine("Output text:\n {0}", line);

                    writeFile.WriteLine(line);
                }

            }
            Console.WriteLine("\nAll substrings with \"start\" have been replaced with \"finish\".");
        }
    }
}

