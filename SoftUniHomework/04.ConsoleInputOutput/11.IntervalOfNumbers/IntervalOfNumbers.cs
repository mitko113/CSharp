using System;

namespace _11.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter beginning of the sequence ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end of the sequence ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',40));

            int elements = 0;

            Console.WriteLine("The numbers divisible by 5 without remainder are: ");
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    elements = i;
                    Console.WriteLine(elements);
                }                
            }
            Console.WriteLine(new string('-',40));
        }
    }
}
