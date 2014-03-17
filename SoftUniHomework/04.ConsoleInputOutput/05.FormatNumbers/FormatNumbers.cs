using System;

namespace _05.FormatNumbers
{
    class FormatNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a floating point number ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second floating point number ");
            double c = double.Parse(Console.ReadLine());
            string binary = Convert.ToString(a,2);


            Console.WriteLine("|{0,-10:X} |{1,10}|  {2,10:F2}|{3,-10:F3}|",a,binary.PadLeft(10, '0'),b,c);
        }
    }
}
