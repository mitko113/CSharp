/* Problem 01.
 * Write a program that enters from the console a positive integer n 
 * and prints all the numbers from 1 to n,
 * on a single line, separated by a space. 
 */

using System;

namespace _01.NumversFromOneToN
{
    class NumversFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'N' ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
