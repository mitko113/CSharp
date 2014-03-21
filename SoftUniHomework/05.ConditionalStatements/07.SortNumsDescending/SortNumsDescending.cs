using System;

namespace _07.SortNumsDescending
{
    class SortNumsDescending
    {
        static void Main()
        {
            Console.WriteLine("Enter first number ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number ");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum >= secondNum && thirdNum < secondNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("{0}, {1}, {2}",firstNum,secondNum,thirdNum);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}",firstNum,thirdNum,secondNum);
                }
            }
            if (thirdNum >= secondNum && firstNum < thirdNum)
            {
                if (secondNum > firstNum)
                {
                    Console.WriteLine("{0}, {1}, {2}",thirdNum,secondNum,firstNum);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}",thirdNum,firstNum,secondNum);
                }
                
            }
            if (secondNum > firstNum && thirdNum < secondNum)
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine("{0}, {1}, {2}",secondNum,firstNum,thirdNum);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}",secondNum,thirdNum,firstNum);
                }
            }
            if (firstNum == secondNum && firstNum == thirdNum && secondNum == thirdNum)
            {
                Console.WriteLine("{0}, {1}, {2}",firstNum,secondNum,thirdNum);
            }
        }
    }
}
