//Problem 13. Solve tasks
/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */

using System;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine(@"Please choose a task from below: 

1 -->> Reverse digits of a number
2 -->> Calculate the average of a sequence of integers
3 -->> Solve a linear equation a * x + b = 0
");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            ReverseNum();
        }
        else if (choice == 2)
        {
            CalculateAverage();
        }
        else if (choice == 3)
        {
            SolveLinearEquation();
        }
        else
        {
            Console.WriteLine("Please choose a correct option!");
        }
    }

    static void ReverseNum()
    {
        Console.Clear();
        Console.Write("Please enter a positive decimal number: ");
        decimal dec = decimal.Parse(Console.ReadLine());
        if (dec > 0)
        {
            // using class from Problem 7
            Console.WriteLine("The number {0} when reversed is {1}\n", dec, ReverseNumber.ReverseDecimal(dec));
        }
        else
        {
            Console.WriteLine("Please enter a positive number!\n");
        }
    }

    static void CalculateAverage()
    {
        Console.Clear();
        Console.WriteLine("Please create an array of integers, separated by a comma/space: ");
        int[] intArray = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        if (intArray.Length == 0)
        {
            Console.WriteLine("Please enter more numbers!");
            return;
        }

        double result = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            result += intArray[i];
        }

        result /= intArray.Length;
        Console.WriteLine("The average is {0}", result);
    }

    static void SolveLinearEquation()
    {
        decimal a = 0;

		do
		{
			Console.Write("Enter a non-zero number A: ");
			a = decimal.Parse(Console.ReadLine());
		}
		while (a == 0);

		Console.Write("Enter a number B: ");
		decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nx = -b / a = {0}\n", -b / a);
    }

}

