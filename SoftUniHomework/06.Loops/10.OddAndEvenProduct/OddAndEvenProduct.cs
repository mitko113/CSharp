/* Problem 10.
 * You are given n integers 
 * Write a program that checks whether the product of the odd elements
 * is equal to the product of the even elements. Elements are counted
 * from 1 to n, so the first element is odd, the second is even.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers you wish to compare: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int position = 0;
            int number = 0;
            int evenProduct = 1;
            int oddProduct = 1;

            for (int i = 0; i < numbers.Length; i++)
			{
                number = int.Parse(numbers[i]);

                if (i % 2 == 0)
                {
                    oddProduct *= number;
                }
                else
                {
                    evenProduct *= number;
                }
			}

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Product = {0}",oddProduct);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Odd product = {0}", oddProduct);
                Console.WriteLine("Even product = {0}", evenProduct);
            }
        }
    }
}
