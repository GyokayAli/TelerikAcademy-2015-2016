//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
/*Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */

using System;

class DateDifference
{
    static void Main()
    {
        Console.Write("Please enter date in format dd:mm:yyyy ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Please enter another date in format dd:mm:yyyy: ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        bool isBigger = date1 > date2;
        Console.WriteLine("Distance: {0}",isBigger ? (date1 - date2).Days : (date2 - date1).Days);
    }
}

