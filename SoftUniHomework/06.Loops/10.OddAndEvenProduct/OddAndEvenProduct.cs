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
