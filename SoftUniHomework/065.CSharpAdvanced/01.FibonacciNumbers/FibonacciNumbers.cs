using System;

namespace _01.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static double PrintFibonacciSequence(int n)
        {
            double temp = 0;
            double firstNum = 0;
            double secondNum = 1;

            for (int i = 0; i < n; i++)
            {
               temp = firstNum;
               firstNum = secondNum;
               secondNum = temp + firstNum;
                              
            }
            return secondNum;
        }

        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintFibonacciSequence(n));
        }
    }
}
