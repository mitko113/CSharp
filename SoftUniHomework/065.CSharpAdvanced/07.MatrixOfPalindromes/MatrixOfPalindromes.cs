using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            Console.WriteLine("Enter the width of the matrix: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the matrix ");
            int width = int.Parse(Console.ReadLine());

            string[,] palMatrix = new string[height, width];

            for (int row = 0; row < height; row++)
            {

                for (int col = 0; col < width; col++)
                {
                    palMatrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
                }
            }
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(palMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
