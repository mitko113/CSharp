using System;

namespace _15.BitsExchange
{
class BitsExchange
{
    static void Main()
    {
        uint n = 255406592;
        Console.WriteLine("The binary number is: " + Convert.ToString(n, 2).PadLeft(32,'0'));


        int exchangeBits = 3;
        int startingPos = 3;
        int exchangeAfterPos = 24;

        int firstSequence = 0;
        int secondSequence = 0;

        for (int i = 0; i < exchangeBits; i++)
        {
            uint fmask = (n >> startingPos) & 1;
            uint smask = (n >> exchangeAfterPos) & 1;

            if (fmask == 0)
            {
                n = (uint)(n | (1 << startingPos));
                n = (uint)(n & (~(1 << exchangeAfterPos)));
            }
            else
            {
                n = (uint)(n & (~(1 << startingPos)));
                n = (uint)(n | (1 << exchangeAfterPos));
            }
            startingPos++;
            exchangeAfterPos++;             
        }
        Console.WriteLine("The modified binary result is: {0} ",Convert.ToString(n,2).PadLeft(32,'0'));
    }
}
}
