using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.GratestCommonDivisor
{
    class GratestCommonDivisor
    {
        static int GreatestCommonDivisor(int x, int y)
        {
            int remainder;
            while (y != 0)
            {
                remainder = x % y;
                x = y;
                y = remainder;
            }
            return x;
        }

        static void Main()
        {
            Console.WriteLine("Enter the value of the first integer: ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of the second integer: ");
            int secondValue = int.Parse(Console.ReadLine());

            Console.WriteLine("The GCD of {0} and {1} is: {2} ",
            firstValue,secondValue,GreatestCommonDivisor(firstValue,secondValue));
        }
    }
}
