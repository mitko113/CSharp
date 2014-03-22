using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.countableNum
{
    class countableNum
    {
        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is countable !");
            }
            else
            {
                Console.WriteLine("The number is uncountable !");
            }
        }
    }
}
