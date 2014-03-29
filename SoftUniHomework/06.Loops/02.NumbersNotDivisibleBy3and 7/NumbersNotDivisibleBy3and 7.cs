using System;

namespace _02.NumbersNotDivisibleBy3and_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'N' ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
