using System;
using System.Linq;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
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
            uint num = uint.Parse(Console.ReadLine()); 
            while (true)
            {
                if (num >= 0 && num < 100)
                {
                    BigInteger catalanNumber = Factorial(2 * num) / (Factorial(num + 1) * Factorial(num));
                    Console.WriteLine(catalanNumber); break;             
                }
                else
                {
                    Console.WriteLine("Wrong input !"); break;
                }
            }
        }
    }
}
