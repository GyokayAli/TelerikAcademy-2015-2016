//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
    {
        static void Main()
        {
            Console.Write("Please enter side a of the trapezoid: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Please enter side b of the trapezoid: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Please enter height h of the trapezoid: ");
            double h = double.Parse(Console.ReadLine());

            // Trapezoid's area formula A = ((a+b)/2)*h
            double area = ((a + b) / 2) * h;

            Console.WriteLine("Trapezoid's area is {0}",area);
        }
}

