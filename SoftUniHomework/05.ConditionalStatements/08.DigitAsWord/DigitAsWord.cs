using System;
using System.Collections.Generic;

namespace _08.DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.WriteLine("Enter a digit between 0 and 9: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num < 10)
            {
                switch (num)
                {
                    case 0: Console.WriteLine("Zero"); break;
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    case 4: Console.WriteLine("Four"); break;
                    case 5: Console.WriteLine("Five"); break;
                    case 6: Console.WriteLine("Six"); break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                    default: Console.WriteLine("Wrong input !");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong input !Please enter a number in range [0....9]");
            }
        }
    }
}
