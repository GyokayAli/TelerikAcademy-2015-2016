//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7

using System;


class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());

            int temp = 0;
            for (int i = 0; i < 3; i++)
            {
                temp = input % 10;
                input = input / 10;
            }
            bool checkIfSeven = temp == 7;

            Console.WriteLine(checkIfSeven);
        }
}
