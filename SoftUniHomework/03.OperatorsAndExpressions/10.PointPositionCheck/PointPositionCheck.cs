using System;

namespace _10.PointPositionCheck
{
class PointPositionCheck
{
    static void Main()
    {
        Console.WriteLine("Enter the value of 'x' ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of 'y' ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
        bool outsideRectangle = (x >= -1 && x <= 5 && y <= 1 && y >= -1);
        bool result = isInCircle && !outsideRectangle;

        Console.WriteLine("The point is in the circle and outside the rectangle: {0}",result);                     
    }
}
}
