using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.NumbersMatrix
{
    class NumbersMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            short num = short.Parse(Console.ReadLine());

            if (num < 1 || num > 20)
            {
                Console.WriteLine("Wrong input !");
            }
            else
            {
                for (int row = 0; row < num; row++)
                {
                    for (int col = row + 1; col <= num + row; col++)
                    {
                        Console.Write(col);
                    }
                    Console.WriteLine();
                }    
            }           
        }
    }
}
