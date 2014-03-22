using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.divisionBy5And7
{
    class divisionBy5And7
    {
        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            int num = int.Parse(Console.ReadLine());

            if ((num % 5 == 0) && (num % 7 == 0))
            {
                Console.WriteLine("The number is divisible by 5 and 7 without remainder");
            }
            else
            {
                Console.WriteLine("The division by 5 and 7 has a reminder.");
            }
        }
    }
}
