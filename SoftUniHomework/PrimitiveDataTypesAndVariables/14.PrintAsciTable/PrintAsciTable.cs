using System;
using System.Text;

namespace _14.PrintAsciTable
{
    class PrintAsciTable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("ASCII table: ");
            char? symbol = null;
            for (int i = 0; i < 255; i++)
			{
                symbol = (char)i;
                Console.WriteLine("Numebr {0} equals symbol {1}", i,symbol);			 
			}
        }
    }
}
