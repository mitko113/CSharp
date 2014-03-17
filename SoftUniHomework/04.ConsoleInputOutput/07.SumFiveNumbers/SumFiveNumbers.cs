using System;

namespace _07.SumFiveNumbers
{
    class SumFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Eter five numbers ");
            double sum = 0;
            for (double i = 0; i < 5; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("The sum of the five numbers is: {0:F2}",sum);
        }
    }
}
