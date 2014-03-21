using System;

namespace _06.BiggestOfFiveNums
{
    class BiggestOfFiveNums
    {
        static void Main()
        {
            Console.WriteLine("Enter first number ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number ");
            double fourthNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number ");
            double fifthNum = double.Parse(Console.ReadLine());

            double biggestNum = 0;

            if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum)
            {
                biggestNum = firstNum;
            }
            else if (secondNum > fifthNum && secondNum > thirdNum && secondNum > fourthNum && secondNum> fifthNum)
            {
                biggestNum = secondNum;
            }
            else if (thirdNum > firstNum && thirdNum > secondNum  && thirdNum >fourthNum && thirdNum > fifthNum)
            {
                biggestNum = thirdNum;
            }
            else if (fourthNum > fifthNum && fourthNum > secondNum && fourthNum > thirdNum && fourthNum > fifthNum )
            {
                biggestNum = fourthNum;
            }
            else
            {
                biggestNum = fifthNum;
            }
            Console.WriteLine("The biggest number is: {0}", biggestNum);
        }
    }
}
