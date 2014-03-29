using System;

namespace _14.DecimalToBinaryNum
{
    class DecimalToBinaryNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number : ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
        }
    }
}
