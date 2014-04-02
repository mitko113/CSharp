/* Problem 06.
 * Write a program that calculates n! / k! 
 * for given n and k (1 < k < n < 100). 
 */

using System;
using System.Linq;
using System.Numerics;

namespace _06.FactorialCalc
{
    class FactorialCalc
    {
        static BigInteger Factorial(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            BigInteger fact = 1;
            for (uint i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'k' ");
            uint k = uint.Parse(Console.ReadLine());

            if (1 < k && k < n && n < 100)
            {
                Console.WriteLine("The result of the expression: {0}", (Factorial(n) / Factorial(k))); 
            }
            else
            {
                Console.WriteLine("Wrong input format !");
            }          
        }
    }
}
