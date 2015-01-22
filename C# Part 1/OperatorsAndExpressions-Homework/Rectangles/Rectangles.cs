//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        // Perimeter formula  P = 2(height + width)
        double perimeter = 2 * (height + width);

        // Area formula A = width * height
        double area = width * height;

        Console.WriteLine("Rectangle's perimeter = {0} and area = {1}", perimeter, area);
    }
}
