/* Problem 03.
 * Write a program that reads from the console a sequence of n integer
 * and returns the minimal, the maximal number,
 * the sum and the average of all numbers 
 */

using System;
using System.Linq;

class MinMaxSumAverageOfN
{
    static void Main()
    {
        Console.WriteLine("Enter the number of integers to be read: ");
        int n = int.Parse(Console.ReadLine());

        int[] numArr = new int[n];

        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of the numbers is: {0:F2}", numArr.Sum());
        Console.WriteLine("The average of the numbers is: {0:F2}", numArr.Average());
        Console.WriteLine("The minimal number is: {0:F2}", numArr.Min());
        Console.WriteLine("The maximal number is: {0:F2}", numArr.Max());
    }
}