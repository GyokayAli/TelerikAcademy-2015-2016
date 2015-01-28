//Problem 10.* Beer Time
/* A beer time is after 1:00 PM and before 3:00 AM.
 * Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
 a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
 * according to the definition above or invalid time if the time cannot be parsed. 
 * Note: You may need to learn how to parse dates and times. */

using System;

class BeerTime
{
        static void Main()
        {
            Console.WriteLine("Please enter the time in format [01..12]:[00..59] AM/PM: ");
            DateTime time = Convert.ToDateTime(Console.ReadLine());
            DateTime beerTime = Convert.ToDateTime("12:59 PM");
            DateTime noBeerTime = Convert.ToDateTime("3:00 AM");
            
            if(time > beerTime && time > noBeerTime)
            {
                Console.WriteLine("Beer time!!!");
            }
            else
            {
                Console.WriteLine("Non-beer time!!!");
            }

        }
}

