using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace _03.CheckPlayCards
{
    class CheckPlayCards
    {
        static void Main()
        {
            string[] validCards = { "2","3","4","5","6","7","8","9","10","J","K","Q","A"};
            Console.WriteLine("Enter your card symbol: ");
            string input = Console.ReadLine();
            if (validCards.Contains(input.ToUpper()))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
