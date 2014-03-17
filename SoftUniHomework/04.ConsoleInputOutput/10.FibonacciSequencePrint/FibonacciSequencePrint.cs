using System;

namespace _10.FibonacciSequencePrint
{
    class FibonacciSequencePrint
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',40));

            double firstNum = 0;
            double secondNum = 1;

            Console.WriteLine("The fibonacci sequence form '0' to 'N' : ");
            for (int i = 0; i < n; i++)
            {
                double temp = firstNum;
                firstNum = secondNum;
                secondNum = temp + firstNum;
                Console.WriteLine(temp);
            }
            Console.WriteLine(new string('-',40));
        }
    }
}
