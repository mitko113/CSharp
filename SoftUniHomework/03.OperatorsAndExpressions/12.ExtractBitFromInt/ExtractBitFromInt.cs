using System;

namespace ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main()
        {
            Console.WriteLine("Enter your number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit position ");
            int bitPosition = int.Parse(Console.ReadLine());

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
            Console.WriteLine("The bit at the given position is: {0}", result);
        }
    }
}
