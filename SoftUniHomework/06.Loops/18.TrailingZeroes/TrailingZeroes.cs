using System;
using System.Numerics;

namespace _18.TrailingZeroes
{
    class TrailingZeroes
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
            Console.WriteLine("Enter a number to calculate its factorial: ");
            uint num = uint.Parse(Console.ReadLine());

            uint zeroesCounter = 0;
            uint divider = 5;
            BigInteger fact = Factorial(num);
            for (uint i = 1; i <= num; i ++)
            {
                zeroesCounter += num / divider;
                divider *= 5;
            }
            Console.WriteLine("The factorial of the number is: {0}", Factorial(num));
            Console.WriteLine("The number of zeroes in factorial: {0}", zeroesCounter);       
        }
    }
}
