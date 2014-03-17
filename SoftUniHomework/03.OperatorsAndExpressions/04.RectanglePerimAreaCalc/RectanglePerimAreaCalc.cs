using System;

namespace _04.RectanglePerimAreaCalc
{
    class RectanglePerimAreaCalc
    {
        static void Main()
        {
            Console.WriteLine("Enter the width of the rectangle: ");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',35));

            float perimeter = 2 * (width + height);
            float area = width * height;

            Console.WriteLine("The perimeter of the rectangle is: {0}",perimeter);
            Console.WriteLine("The area of the rectangle is: {0}",area);
            Console.WriteLine(new string('-',35));
        }
    }
}
