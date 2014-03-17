using System;

namespace _07.PointInsideCircle
{
    class PointInsideCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of point X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of point Y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',35));

            bool isInCircle = false;
            double pointCentre = Math.Sqrt(x * x + y * y);

            if (pointCentre >= radius)
            {
                isInCircle = true;
            }
            else
            {
                isInCircle = false;
            }
            Console.WriteLine("The point is in the circle = {0}",isInCircle);
        }
    }
}
