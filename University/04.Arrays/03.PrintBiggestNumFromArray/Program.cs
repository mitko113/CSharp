using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintBiggestNumFromArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the first array: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the second array: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 35));

            int[] firstArr = new int[a];
            int[] secondArr = new int[b];
            int[] equalElements;

            Console.WriteLine("Enter the elements of the first array: ");
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of the second array: ");
            for (int j = 0; j < secondArr.Length; j++)
            {
                secondArr[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 35));

                      
            equalElements = firstArr.Intersect(secondArr).ToArray();
            for (int i = 0; i < equalElements.Length; i++)
            {
                Console.WriteLine("The equal elements are: " + equalElements[i]);
            }
            Console.WriteLine(new string('-',35));

            int maxNum = equalElements.Max();
            Console.WriteLine("The biggest num of the pari is: {0}", maxNum);
            Console.WriteLine(new string('-',35));
          
        }
    }
}
