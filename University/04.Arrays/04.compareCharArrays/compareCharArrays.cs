using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.compareCharArrays
{
    class compareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the first array ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the second array");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',20 ));

            char[] firstArr = new char[n];
            char[] secondArr = new char[m];

            Console.WriteLine("Enter the values of the first array: ");
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the values of the second array ");
            for (int j = 0; j < secondArr.Length; j++)
            {
                secondArr[j] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-',20));

            if (firstArr.Take(n).SequenceEqual(secondArr.Take(m)))
            {
                Console.WriteLine("The two arrays are equal !");
            }
            else
            {
                Console.WriteLine("The two arrays are not equal !");
            }
        }
    }
}
