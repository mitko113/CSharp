using System;

namespace _11.ExtractBitPosition
{
    class ExtractBitPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter your number ");
            int num = int.Parse(Console.ReadLine());
            int bitPosition = 3;
            byte value = 0;

            int result = (num >> bitPosition) & 1;
            if (result == 0)
            {
                value = 0;
            }
            else
            {
                value = 1;
            }
            Console.WriteLine("The bit at third position is: {0}", result);
        }
    }
}
