using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the first array: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the second array: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',35));

            int[] firstArr = new int [a];
            int[] secondArr = new int [b];

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
            Console.WriteLine(new string('-',35));

            bool isEqual = false;
            if (firstArr.Length == secondArr.Length)
            {
                foreach (var numA in firstArr)
                {
                    foreach (var numB in secondArr)
                    {
                        if (numA == numB)
                        {
                            isEqual = true;
                        }                      
                    }                                       
                }                      
            }           
            Console.WriteLine(isEqual);
        }
    }
}
