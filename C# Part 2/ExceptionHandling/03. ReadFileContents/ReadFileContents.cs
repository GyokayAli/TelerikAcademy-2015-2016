//Problem 3. Read file contents
/*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Please enter the file path: ");
        string filePath = Console.ReadLine();

        //C:\WINDOWS\win.ini   <<-- example to try
        try
        {
            // Read each line of the file into a string array. Each element 
            // of the array is one line of the file. 
            string[] lines = File.ReadAllLines(filePath);

            Console.Clear();
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of file: ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
        }
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine("File not found!");
        }
        catch (System.IO.IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (System.NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (System.ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (System.UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("\nGoodbye!");
        }
    }
}

