using System;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("The number you have entered is even");
            }
            else
            {
                Console.WriteLine("The number you have entered is odd");
            }
        }
    }
}
