using System;


namespace _10.ExchangeVariables
{
    class ExchangeVariables
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Initial print: {0}, {1}", a,b);
           
            int x = a;
            a = b;
            b = x;          
            Console.WriteLine("Exchanged values: {0}, {1}",a,b);
        }
    }
}
