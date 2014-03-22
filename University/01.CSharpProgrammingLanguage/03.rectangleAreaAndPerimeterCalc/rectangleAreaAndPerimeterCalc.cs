using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.rectangleAreaAndPerimeterCalc
{
    class rectangleAreaAndPerimeterCalc
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'a' here: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tthe value of 'b' here: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',30));

            Console.WriteLine("Enter your choice: \n1.Calculate area \n2.Calculate perimeter");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',30));

            double area = a * b;
            double perimeter = 2 * (a + b);

            if (choice == 1)
            {
                Console.WriteLine("The area of the rectangle is: {0}", area);
            }
            else if (choice == 2)
            {
                Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
            }
            else
            {
                Console.WriteLine("Wrong input !");
            }
        }
    }
}
