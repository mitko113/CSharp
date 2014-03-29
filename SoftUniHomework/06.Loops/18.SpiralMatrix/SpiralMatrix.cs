using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int rotation = n * n;
            string direction = "right";

            int row = 0;
            int col = 0;
            

            int colEnd = n - 1;
            int rowEnd = n - 1;

            for (int i = 0; i <= rotation; i++)
            {

                matrix[row, col] = i;
                

                if (direction == "right" && (col > n - 1))
                {
                    direction = "down";
                    row--;
                    col++;
                }
                if (direction == "down" && (row > n - 1))
                {
                    direction = "left";
                    col--;
                    row--;
                }
                if (direction == "left" && col < 0)
                {
                    direction = "up";
                    row--;
                    col++;
                }
                if (direction == "up" && row < 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(matrix[j,k]);
                }
                Console.WriteLine();
                
            }
            


        }
    }
}
