using System;

namespace _08.PrimeNumCheck
{
    class PrimeNumCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
                       
            if (num == 1)
            {
                isPrime = false;
            }
            if (num == 2)
            {
                isPrime = true;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }              
            }
            Console.WriteLine(isPrime);                                  
        }
    }
}
