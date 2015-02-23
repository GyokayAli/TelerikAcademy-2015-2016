//Problem 12. Subtracting polynomials
//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Linq;

class SubMultPolynomials
    {
        static void Main()
        {
            decimal[] firstPol = InputPolynomial(out firstPol);
            decimal[] secondPol = InputPolynomial(out secondPol);
            decimal[] subResult = new decimal[Math.Max(firstPol.Length, secondPol.Length)];
            decimal[] mulResult = new decimal[(firstPol.Length + secondPol.Length)];

            Console.Write("First polynom:    ");
            PrintPolynom(firstPol);
            Console.Write("Second polynom:   ");
            PrintPolynom(secondPol);

            subResult = SubPolynomial(firstPol, secondPol, subResult);
            Console.Write("\nSub               ");
            PrintPolynom(subResult);

            mulResult = MultiplicationofPolynom(firstPol, secondPol, mulResult);
            Console.Write("\nMultiplication:   ");
            PrintPolynom(mulResult);

        }

        static decimal[] SubPolynomial(decimal[] first, decimal[] second, decimal[] result)
        {
            if (first.Length > second.Length)
            {
                return SubPolynomial(second, first, result);
            }

            int i = 0;

            for (; i < first.Length; i++)
            {
                result[i] = first[i] - second[i];
            }

            for (; i < second.Length; i++)
            {
                result[i] = second[i];
            }

            return result;
        }

        static decimal[] MultiplicationofPolynom(decimal[] first, decimal[] second, decimal[] result)
        {

            if (first.Length > second.Length)
            {
                return SubPolynomial(second, first, result);
            }

            int i = 0;

            for (; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    int position = i + j;
                    result[position] += (first[i] * second[j]);
                }
            }

            for (; i < second.Length; i++)
            {
                result[i] = second[i];
            }

            return result;
        }

        static void PrintPolynom(decimal[] polynom)
        {

            for (int i = polynom.Length - 1; i >= 0; i--)
            {
                if (polynom[i] != 0 && i != 0)
                {
                    if (polynom[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, polynom[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0}  ", i, polynom[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polynom[i]);
                }
            }
            Console.WriteLine();
        }

        static decimal[] InputPolynomial(out decimal[] polynom)
        {

            Console.Write("Enter your polynomial degree: ");
            byte degree = byte.Parse(Console.ReadLine());
            polynom = new decimal[degree + 1];
            for (int i = polynom.Length - 1; i >= 0; i--)
            {
                Console.Write("x^" + i + ": ");
                polynom[i] = decimal.Parse(Console.ReadLine());
            }
            return polynom;
        }
    }

