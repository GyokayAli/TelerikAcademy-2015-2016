namespace GenericList
{
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            TestGenericList();
        }

        public static void TestGenericList()
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(155);
            list.Add(53);
            list.Add(99);

            list.Remove(1);

            list.Insert(111, 1);

            Console.WriteLine(list);
            Console.WriteLine("Element with value {0} is at position {1}", 53, list.ElementByValue(53));
            Console.WriteLine("Min element: {0}", list.Min<int>());
            Console.WriteLine("Max element: {0}", list.Max<int>());

            list.Clear();
            Console.WriteLine("\nList cleared...");

            list.Add(155);
            list.Add(53);
            list.Add(99);
            Console.WriteLine();
            Console.WriteLine("New list:");
            Console.WriteLine(list);
        }
    }
}
