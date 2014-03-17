using System;

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',40));

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(new string('-',40));

            Console.WriteLine("The sum of the 'N' numbers is: {0:F2}",sum);
        }
    }
}
