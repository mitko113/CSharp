using System;

namespace _02.MoonGravitationCalc
{
    class MoonGravitationCalc
    {
        static void Main()
        {
            Console.WriteLine("Enter your weight: ");
            float weight = float.Parse(Console.ReadLine());
            float weightOnTheMoon = 0.17f * weight;
            Console.WriteLine("Your weight on the moon will be: {0:F3}",weightOnTheMoon);
        }
    }
}
