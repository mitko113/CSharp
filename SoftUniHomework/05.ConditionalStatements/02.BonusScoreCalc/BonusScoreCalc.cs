using System;

namespace _02.BonusScoreCalc
{
    class BonusScoreCalc
    {
        static void Main()
        {
            Console.WriteLine("Enter your score: ");
            double score = double.Parse(Console.ReadLine());

            if (score > 0 && score < 4)
            {
                score *= 10;                
            }
            else if (score > 3 && score < 7)
            {
                score *= 100;
            }
            else if (score > 6 && score < 10)
            {
                score *= 1000;
            }
            else
            {
                Console.WriteLine("Invalid score! You must enter a number in range [1...9]");
            }
            Console.WriteLine("Your score is {0:F2}", score);
        }
    }
}
