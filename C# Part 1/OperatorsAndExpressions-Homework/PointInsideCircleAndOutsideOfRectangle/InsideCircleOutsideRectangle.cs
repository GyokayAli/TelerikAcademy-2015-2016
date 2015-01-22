//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Drawing;


class InsideCircleOutsideRectangle
    {
        static void Main()
        {
            double radius = 1.5;
          
            Console.Write("Please enter x value: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please enter y value: ");
            double y = double.Parse(Console.ReadLine());

            bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius;
            bool inRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

            Console.WriteLine("x = {0} and y = {1} are inside the circle and outside the rectangle? \n\n  Answer: {2}",
                x, y, inCircle && !inRectangle ? "yes" : "no");
        }
    }

