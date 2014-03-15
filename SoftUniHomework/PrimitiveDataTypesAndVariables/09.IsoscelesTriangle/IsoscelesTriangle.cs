using System;
using System.Text;

namespace _09.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';

            int width = 7;
            int n = 3;
            
            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
                for (int k = 0; k < n; k++)
                {                                    
                    if ((n - k) != j + 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write( symbol);
                    }
                }
                for (int k = 0; k < n; k++)
                {               
                    if (k != j - 1)
                    {
                        Console.Write(" ");
                    }                    
                    else
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();              
            }

            for (int i = 0; i <= width / 2; i++)
            {
                Console.Write(symbol + " ");
            }                               
        }
    }
}
