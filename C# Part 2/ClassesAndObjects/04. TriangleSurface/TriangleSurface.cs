//Problem 4. Triangle surface
/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

using System;

 class TriangleSurface
    {
        static void Main()
        {
            Console.Write("Side A of triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Side B of triangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Side C of triangle: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Altitude H of a triangle: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Angle of a triangle: ");
            double angle = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Surface using a side and altitude: {0}",GetSurfaceWithAltitude(a,h));
            Console.WriteLine("Surface using three sides: {0}",GetSurfaceWithThreeSides(a,b,c));
            Console.WriteLine("Surface using two sides and an angle: {0}", GetSurfaceWithAngle(a, b, angle));
        }
        static double GetSurfaceWithAltitude(double a, double h)
        {
            return (a * h) / 2;
        }

        static double GetSurfaceWithThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        static double GetSurfaceWithAngle(double a, double b, double angle)
        {
            return (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
        }
    }

