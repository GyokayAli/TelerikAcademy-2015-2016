//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
    {
        static void Main()
        {
            int radius = 2;

            Console.Write("Please enter x value: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please enter y value: ");
            double y = double.Parse(Console.ReadLine());

            bool isInside = (x - 0) * (x - 0) + (y - 0) * (y - 0) <= radius * radius ? true : false;
            Console.WriteLine("x = {0} and y = {1} are in the circle? {2}",x,y,isInside);
        }
}
