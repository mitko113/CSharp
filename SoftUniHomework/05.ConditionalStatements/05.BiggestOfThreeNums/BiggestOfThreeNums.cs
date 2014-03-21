using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggestOfThreeNums
{
    class BiggestOfThreeNums
    {
        static void Main()
        {
            Console.WriteLine("Enter first number ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number ");
            double c = double.Parse(Console.ReadLine());

            double biggestNum = 0;

            if (a > b && a > c)
            {
                biggestNum = a;
            }
            else if (b > a && b > c)
            {
                biggestNum = b;
            }
            else if (c > a && c > b)
            {
                biggestNum = c;
            }
            Console.WriteLine("The biggest number is: {0}", biggestNum);
        }
    }
}
