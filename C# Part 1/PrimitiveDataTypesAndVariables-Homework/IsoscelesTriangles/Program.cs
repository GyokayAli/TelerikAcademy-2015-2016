//Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

//     ©

//    © ©

//   ©   ©

//  © © © ©

using System;


namespace IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize variables
            int num = 9;
            char symbol = '\u00a9';
            
            //top line
            string blankOut = new String(' ', (num-2)/2);
            Console.WriteLine(blankOut + symbol + blankOut);
            Console.WriteLine();
            
            //characters and spaces between the top and bottom lines 
            for (int i = 0, j = 2; 0 < j; i++, j--)
            {
                blankOut = new String(' ', j);
                string blankIn = new String(' ', i * 2 + 1);

                Console.WriteLine(blankOut + symbol + blankIn + symbol);
                Console.WriteLine();
            }

            //bottom line
            for (int i = 0; i < num-1; i++)
            {
                if (i % 2 == 1) 
                    Console.Write(" ");
                else
                    Console.Write(symbol);
            }
            Console.ReadKey();
        }
    }
}
