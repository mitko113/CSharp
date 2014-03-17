using System;

namespace _09.CalcTrapezoidArea
{
    class CalcTrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'a' ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'b' ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'h' ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',35));

            double area = (a + b) / 2 * h;
            Console.WriteLine("The area of the trapezoid is: {0}",area);
            Console.WriteLine(new string('-',35));
        }
    }
}
