/* Problem 05.
 * Write a program that, for a given two integer numbers n and x, 
 * calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
 */

using System;

namespace _05.CalculateExpression
{
    class CalculateExpression
    {
        static uint Factorial(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            uint fact = 1;
            for (uint i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'x' ");
            double x = double.Parse(Console.ReadLine());
            double expression = 0;
            for (uint i = 1; i <= n; i++)
			{
                expression = 1 + Factorial(i) / Math.Pow(x, i);
			}

            Console.WriteLine("Expression result: {0:F4}", expression);
        }
    }
}
