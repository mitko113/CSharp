using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Enter the value of 'a' ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'b' ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'c' ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',40));

            double diskriminante = b * b - 4 * a * c;

            if (diskriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(diskriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diskriminante)) / (2 * a);
                Console.WriteLine("The real solution x\u2081 = {0:F2}", x1);
                Console.WriteLine("The real solution x\u2082 = {0:F2}", x2);
            }
            else if (diskriminante == 0)
            {
                double x12 = (-b / (2 * a));
                Console.WriteLine("The one real solution x\u2081 =x\u2082 = {0:F2}", x12);
            }
            else
            {
                Console.WriteLine("There are no real solutions !");
            }
        }
    }
}
