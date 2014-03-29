using System;

namespace _02.PrimeNumber
{
    class PrimeNumber
    {
        static bool isPrime(long n)
        {
            int max = (int)Math.Sqrt(n);
            if (n == 0 || n == 1)
            {
                return false;
            }           
            if (n == 2)
            {
                return true;
            }
            for (int i = 2; i <= max; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(num));
        }
    }
}
