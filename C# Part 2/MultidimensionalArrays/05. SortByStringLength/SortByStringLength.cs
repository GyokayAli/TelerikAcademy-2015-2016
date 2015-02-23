//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;

class SortByStringLength
{
        static void Main()
        {
            string[] names = { "John", "Michael", "Daniel", "Jamie", "Paul","Rokas","Dhruv","Thinesh","William","Khanavatharian" };

            Array.Sort(names, new Comparer());

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public class Comparer : IComparer<string>
        {
            public int Compare(string name1, string name2)
            {
                return name1.Length.CompareTo(name2.Length);
            }
        }
}

