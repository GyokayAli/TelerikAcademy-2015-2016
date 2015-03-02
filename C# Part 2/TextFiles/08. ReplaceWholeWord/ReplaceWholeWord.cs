//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        var readFile = new StreamReader("../../Files/words.txt");
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
                    line = Regex.Replace(line,@"\bstart\b", "finish");

                    Console.WriteLine("Output text:\n {0}", line);

                    writeFile.WriteLine(line);
                }

            }
            Console.WriteLine("\nAll words \"start\" have been replaced with \"finish\".");
        }
    }
}

