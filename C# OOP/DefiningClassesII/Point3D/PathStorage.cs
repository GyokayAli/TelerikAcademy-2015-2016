namespace Point3D
{
    using System;
    using System.IO;
    public static class PathStorage
    {
        public static Path path = new Path();

        public static void Load(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        double x = 0;
                        double y = 0;
                        double z = 0;

                        string[] readPoints = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        x = double.Parse(readPoints[0]);
                        y = double.Parse(readPoints[1]);
                        z = double.Parse(readPoints[2]);

                        Point3D newPoint = new Point3D(x, y, z);

                        path.Add(newPoint);

                        line = sr.ReadLine();
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("File name cannot be empty string.");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Wrong or incorect file name");
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Wrong or missing directory.");
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("File not saved.");
                Console.WriteLine(e.Message);
            }

        }

        public static void Save(Path pointsList, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (Point3D point in pointsList.PointList)
                    {
                        string line = string.Format("{0} {1} {2}", point.X, point.Y, point.Z);
                        sw.WriteLine(line);
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("You cannot access file!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("File name cannot be empty string.");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Wrong or incorect file name");
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Wrong or missing directory.");
                Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Path name too long. Try other directory.");
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("File not saved.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
