using System;

namespace _14.ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter your number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit position ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value (0/1) ");
            int bitValue = int.Parse(Console.ReadLine());

            int mask = 1 << p;

            if (bitValue == 0)
            {              
                num = num & (~mask);
                Console.WriteLine(num);

            }
            else if (bitValue == 1)
            {               
                num = num | mask;
                Console.WriteLine(num);
            }                                     
        }
    }
}
