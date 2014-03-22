using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
class Trapezoid
{
    static void Main()
    {
           
        int trapezoidWidth = int.Parse(Console.ReadLine());
        int width = trapezoidWidth * 2;
        int height = trapezoidWidth + 1;
                 
        for (int row = 0; row < height ; row++)
        {             
            for (int col = 0; col < width ; col++)
            {
                    
                if (col <= trapezoidWidth - row - 1)
                {
                    Console.Write(".");
                }
                else
                {
                    if (row == 0 || row == trapezoidWidth)
                    {
                        Console.Write("*");
                    }
                    else if (col == trapezoidWidth - row || col == (2 * trapezoidWidth) - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }                                 
            }                         
            Console.WriteLine();
        }
    }
}
}
