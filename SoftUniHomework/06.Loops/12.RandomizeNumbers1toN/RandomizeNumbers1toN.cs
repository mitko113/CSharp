using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers1toN
{
    class RandomizeNumbers1toN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of 'n' ");
            int n = int.Parse(Console.ReadLine());
            
            Random randomGen = new Random();

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(randomGen.Next(i,n + 1) + " ");
            }
        }
    }
}
