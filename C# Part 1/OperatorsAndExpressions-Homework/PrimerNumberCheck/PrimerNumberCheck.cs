//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimerNumberCheck
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number : ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {               
                if (num % i == 0)
                {
                    isPrime = false;              
                }    
            }
            if (num == 1 || num <= 0) 
                isPrime = false;

            Console.WriteLine("The integer {0} is prime number: {1}", num, isPrime);
        }    
}

