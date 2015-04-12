/*
 * static class with a static method to calculate the distance between two points in the 3D space.
*/

namespace Point3D
{
    using System;

    public static class CalculateDistance
    {
        public static double CalculateDist(Point3D point1, Point3D point2)
        {
            return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) +
                            (point1.Y - point2.Y) * (point1.Y - point2.Y) +
                            (point1.Z - point2.Z) * (point1.Z - point2.Z));
        }
    }
}
