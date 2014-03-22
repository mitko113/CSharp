using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LongestSequenceOfConseqElements
{
    class LongestSequenceOfConseqElements
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array ");
            int n = int.Parse(Console.ReadLine());
            int[] numbersArr = new int[n];
            Console.WriteLine("Enter the values of the array ");
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(Console.ReadLine());
            }

            int length = 1;
            int maxLength = 0;
            int indexEnd = 0;

            for (int i = 0; i < numbersArr.Length - 1; i++)
            {
                if (numbersArr[i] < numbersArr[i + 1])
                {
                    length++;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        indexEnd = numbersArr[i];
                    }
                }
                length = 1;
            }
            if (length > maxLength)
            {
                maxLength = length;
                indexEnd = numbersArr.Length - 1;
            }
            
            Console.Write("The longest sequence of consequtive numbers is: ");
            for (int i = indexEnd - maxLength + 1; i < indexEnd + 1; i++)
            {
                Console.Write(" {0}, ", numbersArr[i]);
            }
            Console.WriteLine();           
        }
    }
}
