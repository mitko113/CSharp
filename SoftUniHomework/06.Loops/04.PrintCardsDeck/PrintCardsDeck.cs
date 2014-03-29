using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintCardsDeck
{
    class PrintCardsDeck
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            char spade = '\u0006';
            char heart = '\u0003';
            char club = '\u0005';
            char diamond = '\u0004';

            for (int i = 2; i < 15; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    switch (i)
                    {
                        case 2: Console.Write("2");
                            break;
                        case 3: Console.Write("3");
                            break;
                        case 4: Console.Write("4");
                            break;
                        case 5: Console.Write("5");
                            break;
                        case 6: Console.Write("6");
                            break;
                        case 7: Console.Write("7");
                            break;
                        case 8: Console.Write("8");
                            break;
                        case 9: Console.Write("9");
                            break;
                        case 10: Console.Write("10");
                            break;
                        case 11: Console.Write("J");
                            break;
                        case 12: Console.Write("Q");
                            break;
                        case 13: Console.Write("K");
                            break;
                        case 14: Console.Write("A");
                            break;
                    }
                    
                    switch (j)
                    {
                        case 1: Console.Write(spade);
                            break;
                        case 2: Console.Write(heart);
                            break;
                        case 3: Console.Write(club);
                            break;
                        case 4: Console.Write(diamond);                           
                            break;                           
                    }                   
                }
                Console.WriteLine();
            }
        }
    }
}
