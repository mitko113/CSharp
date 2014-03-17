using System;

namespace _14.PrintDateTime
{
    class PrintDateTime
    {
        static void Main()
        {
            DateTime currentDt = new DateTime();
            currentDt = DateTime.Now;
            Console.WriteLine(currentDt);
        }
    }
}
