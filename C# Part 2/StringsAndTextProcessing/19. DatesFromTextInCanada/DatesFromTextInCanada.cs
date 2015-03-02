//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;
using System.Globalization;
class DatesFromTextInCanada
{
    static void Main()
    {
        string text = "Tommy was born in 01.12.1991 and his little brother 09.03.1994.";
        DateTime date;
        foreach (Match item in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
    }
}

