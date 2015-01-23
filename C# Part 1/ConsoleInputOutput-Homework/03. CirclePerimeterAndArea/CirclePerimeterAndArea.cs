//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.


using System;

class CirclePerimeterAndArea
{
        static void Main()
        {
            Console.Write("Please enter circle's radius: ");
            double radius = double.Parse(Console.ReadLine());

            //Formula of circle's perimeter C = 2πr
            double perimeter = 2 * Math.PI * radius;

            //Formula of circle's area A = πr^2
            double area = Math.PI * (radius * radius);

            Console.WriteLine(@"
Perimeter of circle: {0:F2}
Area of circle: {1:F2}",perimeter,area);
        }
}

