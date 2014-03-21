using System;

namespace _01.ExchangeValues
{
    class ExchangeValues
    {
        static void Main()
        {
            int firstNum = 5;
            int secondNum = 3;
            int temp = 0;

            if (firstNum > secondNum)
            {
                temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;              
            }
            Console.WriteLine(firstNum + " " + secondNum);
        }
    }
}
