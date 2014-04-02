/* Problem 09.
 * Write a program that reads from the console 
 * a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
 * 
 * Example input01:2	 Example output: 1 2   
                                         2 3
 * 
 * Example input02:3     Example outpit:1 2 3
                                        2 3 4
                                        3 4 5
 */

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
