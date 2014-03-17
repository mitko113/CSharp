using System;


namespace _05.FindThirdDigit
{
    class FindThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter your number ");
            int num = int.Parse(Console.ReadLine());
            bool isThirdDigit7 = false;

            Console.Write("Is the third digit 7 = ");
            num = num / 100;
            if (num % 10 == 7)
            {
                isThirdDigit7 = true;              
            }
            else
            {
                isThirdDigit7 = false;
            }
            Console.WriteLine(isThirdDigit7);
        }
    }
}
