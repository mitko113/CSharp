﻿using System;

namespace _01.IntegerSum
{
    class IntegerSum
    {
        static void Main()
        {
            Console.WriteLine("Enter first number ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number ");
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum + thirdNum;
            Console.WriteLine("The sum of the three numbers is: {0}",sum);
        }
    }
}
