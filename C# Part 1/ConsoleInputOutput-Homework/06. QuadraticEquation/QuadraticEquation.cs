//Problem 6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;


class QuadraticEquation
{
        static void Main()
        {
            Console.Write("Please enter the coefficient a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Please enter the coefficient b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Please enter the coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c; //discriminant of the quadratic polynomial
            
            if(d < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x);
            }
            else
            {
                double root1 = (-b - Math.Sqrt(d)) / (2 * a); 
                double root2 = (-b + Math.Sqrt(d)) / (2 * a); 
                Console.WriteLine("x1 = {0} and x2 = {1}", root1, root2);
            }        
        }
}

