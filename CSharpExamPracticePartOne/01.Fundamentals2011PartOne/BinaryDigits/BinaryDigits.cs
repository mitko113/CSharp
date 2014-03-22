using System;
using System.Collections.Generic;

namespace BinaryDigits
{
    class BinaryDigits
    {

        static int BitCounter(ulong n, short counter) 
        {
            counter = 0;
            while (n > 0)
            {
                if (0 == (n & 1))
                {
                    counter++;
                }               
                n = n >> 1;
            }
            return counter;                    
        }

        static int BitCounter1(ulong n, short counter)
        {
            counter = 0;
            while (n != 0)
            {
                if (1 == (n & 1))
                {
                    counter++;
                }
                n = n >> 1;               
            }
            return counter;
        }

        static void Main()
        {
            byte bitValue = byte.Parse(Console.ReadLine());
            short n = short.Parse(Console.ReadLine());
            ulong[] number = new ulong[n];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = ulong.Parse(Console.ReadLine());
            }

            int result = 0;

            if (bitValue == 0)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    result = BitCounter(number[i], counter);
                    Console.WriteLine(result);
                }
            }
            else if (bitValue == 1)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    result = BitCounter1(number[i], counter);
                    Console.WriteLine(result);
                }
            }
        }
          public static short counter { get; set; }
    }
}
