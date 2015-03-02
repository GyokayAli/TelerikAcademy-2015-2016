//Problem 12. Remove words
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class RemoveWords
{
    static void Main()
    {
        string forbiddenWords = "../../Files/forbidden_words.txt";
        string inputPath = "../../Files/text.txt";
        string resultPath = "../../Files/results.txt";
        try
        {
            using (StreamWriter sw = new StreamWriter(resultPath))
            {
                using (StreamReader sr = new StreamReader(inputPath))
                {
                    string line;
                    string regex = @"\b(" + String.Join("|", File.ReadAllLines(forbiddenWords)) + @")\b";
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, regex, string.Empty);
                        sw.WriteLine(line);
                    }
                }
            }
        }
        catch (FieldAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

