using System;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = 2 * width - 1;
            int counter = 0;

            for (int row = 1; row <= width; row++)
            {
                counter++;
                for (int col = 1; col <= width; col++)
                {
                    if (counter == col)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

            for (int row = 1; row < width; row++)
            {
                counter--;
                for (int col = 1; col <= width; col++)
                {
                    if (counter == col)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
