using System;

namespace _01.NumversFromOneToN
{
    class NumversFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'N' ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
