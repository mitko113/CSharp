using System;

namespace _03.CircleAreaPerimCalc
{
    class CircleAreaPerimCalc
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius of the circle ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(new string('-',40));

            Console.WriteLine("1.The perimeter of the circle is: {0:F2}", perimeter);
            Console.WriteLine("2.The area of the circle is: {0:F2}",area);
            Console.WriteLine(new string('-',40));
        }
    }
}
