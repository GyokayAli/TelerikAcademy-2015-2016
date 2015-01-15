//Problem 12. Null Values Arithmetic
/* Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console.
 * Try to add some number or the null literal to these variables and print the result.*/

using System;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int? intNull = null;
            double? doubleNull = null;
            
            Console.WriteLine("Integer with null: " + intNull);
            Console.WriteLine("Double with null: " + doubleNull);
            
            intNull = 12345;
            doubleNull = 2222.2456;

            Console.WriteLine("New int: " + intNull);
            Console.WriteLine("New double: " + doubleNull);          
        }
    }
}
