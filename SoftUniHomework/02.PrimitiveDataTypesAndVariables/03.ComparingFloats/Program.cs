using System;


namespace _03.ComparingFloats
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal roundedFirst = decimal.Round(firstNum, 6);
            decimal roundedSecond = decimal.Round(secondNum, 6);

            if (roundedFirst > roundedSecond)
            {
                Console.WriteLine("The first number is bigger");
            }
            else if (roundedSecond > roundedFirst)
            {
                Console.WriteLine("The second number is bigger");
            }
            else
            {
                Console.WriteLine("The numbers are queal");
            }
        }
    }
}
