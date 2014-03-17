using System;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter your number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position to check ");
            int p = int.Parse(Console.ReadLine());
            byte value = 0;
            bool correctValue = false;

            int result = (num >> p) & 1;
            if (result == 1)
            {
                correctValue = true;
            }
            else
            {
                correctValue = false;
            }
            Console.WriteLine("Is the bit at the given position '1':  {0}",correctValue);          
        }
    }
}
