/*Problem 05.
 *Write a program that reads a number n and a sequence of n integers
 *sorts them and prints them.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the sequence: ");
            int n = int.Parse(Console.ReadLine());

            int[] numArr = new int[n];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());             
            }

            Array.Sort(numArr);

            foreach (int num in numArr)
            {
                Console.WriteLine(num);
            }         
        }
    }
}
