/* Problem 07.
 * Your task is to write a program that calculates n! / (k! * (n-k)!)
 * for given n and k (1 < k < n < 100). 
 */

using System;
using System.Numerics;
using System.Linq;

namespace _07.NumberOfCombinationsCalc
{
    class NumberOfCombinationsCalc
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
            Console.WriteLine("Enter the value of 'n'");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'k'");
            uint k = uint.Parse(Console.ReadLine());
            

            if (1 < k && k < n && n < 100)
            {
                Console.WriteLine("The result of the expression is: {0}",Factorial(n) / (Factorial(k) * Factorial(n - k)));
            }
            else
            {
                Console.WriteLine("Wrong input format !");
            }
        }
    }
}
