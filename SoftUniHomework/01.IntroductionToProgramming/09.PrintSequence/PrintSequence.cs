using System;

namespace _09.PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    Console.Write("{0}, ", -i);
                }              
            }
            Console.WriteLine();
        }
    }
}
