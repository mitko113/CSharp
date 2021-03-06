﻿/* Problem 13.
 * Using loops write a program that converts a binary integer number to its decimal form. 
 * The input is entered as string.
 * The output should be a variable of type long. 
 */

using System;

namespace _13.BinaryToDecNum
{
    class BinaryToDecNum
    {
        static void Main()
        {
            Console.WriteLine("Enter binary number: ");
            string binaryInput = Console.ReadLine();
            long decimalResult = 0;
            for (int i = 0; i < binaryInput.Length; i++)
            {
                if (binaryInput[binaryInput.Length-i-1] == '0' )
                {
                    continue;
                }
                decimalResult += (int)Math.Pow(2, i);
            }
            Console.WriteLine("The decimal representation is: {0}", decimalResult);
        }
    }
}
