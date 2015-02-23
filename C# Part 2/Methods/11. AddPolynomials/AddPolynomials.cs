//Problem 11. Adding polynomials
//Write a method that adds two polynomials. Represent them as arrays of their coefficients.
//Example:

//        x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;
using System.Linq;


    class AddPolynomials
    {
        static void Main(string[] args)
        {

            decimal[] firstPol = InputPolynomial(out firstPol);
            decimal[] secondPol = InputPolynomial(out secondPol);

            decimal[] result = new decimal[Math.Max(firstPol.Length, secondPol.Length)];

            Console.Write("First polynom:    ");
            PrintPolynom(firstPol);
            Console.Write("Second polynom:   ");
            PrintPolynom(secondPol);
            result = AddPolynomial(firstPol, secondPol, result);
            Console.Write("Add               ");
            PrintPolynom(result);

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

        static decimal[] AddPolynomial(decimal[] first, decimal[] second, decimal[] result)
        {

            if (first.Length > second.Length)
            {
                return AddPolynomial(second, first, result);
            }

            int i = 0;

            for (; i < first.Length; i++)
            {
                result[i] = first[i] + second[i];
            }

            for (; i < second.Length; i++)
            {
                result[i] = second[i];
            }

            return result;
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

