namespace Point3D
{
    using System;

    class Test
    {
        private static void Main()
        {
            var initial = new Point3D();
            var point1 = new Point3D(0, 4, 2);
            var point2 = new Point3D(3, 6, 1);

            Console.WriteLine("Initial point: {0}", initial.InitialXYZ);

            Console.WriteLine("Point 1: {0}", point1);
            Console.WriteLine("Point 2: {0}", point2);

            Console.WriteLine("\nDistance between Point 1 and Point 2:\n{0}", CalculateDistance.CalculateDist(point1, point2));

            Path pathList = new Path();
            pathList.Add(point1);
            pathList.Add(point2);

            PathStorage.Save(pathList, @"../../testPath.txt");
            PathStorage.Load(@"../../testPath.txt");

            Console.WriteLine("\nList of paths stored in the text file: ");
            foreach (Point3D point in PathStorage.path.PointList)
            {
                Console.WriteLine(point);
            }
        }

    }
}
