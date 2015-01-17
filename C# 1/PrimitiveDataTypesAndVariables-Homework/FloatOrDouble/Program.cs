//Problem 2. Float or Double?
//Which of the following values can be assigned to a variable of type float and 
//which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;


namespace FloatOrDouble
{
    class Program
    {
        static void Main()
        {
            double num1 = 34.567839023;
            float num2 = 12.345f; 
            double num3 = 8923.1234857;
            float num4 = 3456.091f;

            Console.WriteLine("{0}, {1}, {2}, {3}", num1, num2, num3, num4);           
        }
    }
}
