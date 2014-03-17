using System;

namespace _03.DivisionWithoutRemainder
{
    class DivisionWithoutRemainder
    {
        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            
            bool isDivisible = false;

            Console.Write("Divisible by 5 and 7: ");
            if ((num % 5 == 0) && (num % 7 == 0))
            {
                isDivisible = true;              
            }
            else
            {
                isDivisible = false;              
            }
            Console.WriteLine(isDivisible);
        }
    }
}
