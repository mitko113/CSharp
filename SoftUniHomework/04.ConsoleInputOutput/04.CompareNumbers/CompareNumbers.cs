using System;

namespace _04.CompareNumbers
{
    class CompareNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',35));

            double max1 = Math.Max(firstNum, secondNum);
            Console.WriteLine("The bigger number is: {0}",max1);
        }
    }
}
