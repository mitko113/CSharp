/* Problem 11.
 * Write a program that enters 3 integers n, min and max (min ≤ max) 
 * and prints n random numbers in the range [min...max]. 
 */

using System;

namespace _11.RndNumsInRange
{
    class RndNumsInRange
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min value: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max value: ");
            int max = int.Parse(Console.ReadLine());

            Random randomGen = new Random();

            if (min < max)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(randomGen.Next(min,max + 1) + " ");
                }
            }
            else
            {
                Console.WriteLine("Wrong input !");
            }  
        }
    }
}
